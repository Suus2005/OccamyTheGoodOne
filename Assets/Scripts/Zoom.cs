using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Zoom : MonoBehaviour
{
    public Camera cam;
    public float zoomSpeed = 40f;
    public float minFOV = 20f;
    public float maxFOV = 60f;
    public float defaultFOV = 60f;

    public float resetDuration = 1f; // Time to reset (in seconds)

    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Coroutine resetCoroutine;

    [HideInInspector] public bool isZoomingIn = false;
    [HideInInspector] public bool isZoomingOut = false;

    void Start()
    {
        if (cam == null) cam = Camera.main;

        originalPosition = cam.transform.position;
        originalRotation = cam.transform.rotation;
    }

    void Update()
    {
        if (isZoomingIn)
            cam.fieldOfView -= zoomSpeed * Time.deltaTime;

        if (isZoomingOut)
            cam.fieldOfView += zoomSpeed * Time.deltaTime;

        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minFOV, maxFOV);
    }

    public void StartZoomIn() => isZoomingIn = true;
    public void StopZoomIn() => isZoomingIn = false;

    public void StartZoomOut() => isZoomingOut = true;
    public void StopZoomOut() => isZoomingOut = false;

    public void ResetCamera()
    {
        if (resetCoroutine != null) StopCoroutine(resetCoroutine);
        resetCoroutine = StartCoroutine(SmoothReset());
    }

    private IEnumerator SmoothReset()
    {
        Vector3 startPos = cam.transform.position;
        Quaternion startRot = cam.transform.rotation;
        float startFOV = cam.fieldOfView;

        float elapsed = 0f;

        while (elapsed < resetDuration)
        {
            float t = elapsed / resetDuration;
            cam.transform.position = Vector3.Lerp(startPos, originalPosition, t);
            cam.transform.rotation = Quaternion.Slerp(startRot, originalRotation, t);
            cam.fieldOfView = Mathf.Lerp(startFOV, defaultFOV, t);

            elapsed += Time.deltaTime;
            yield return null;
        }

        // Snap to final values to clean up any precision issues
        cam.transform.position = originalPosition;
        cam.transform.rotation = originalRotation;
        cam.fieldOfView = defaultFOV;
    }
}

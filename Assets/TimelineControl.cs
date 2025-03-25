using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class TimelineControl : MonoBehaviour
{

    public PlayableDirector playableDirector;  // Reference to Playable Director
    public Button Kronkelen;                  // Reference to the play button
    public Button stop;                  // Reference to the stop button
    public Button Idle;
  

    void Start()
    {
        // Add listeners to buttons to play or stop the timeline when clicked
        Kronkelen.onClick.AddListener(PlayTimeline);
        stop.onClick.AddListener(StopTimeline);

    }



    void PlayTimeline()
    {
        if (playableDirector != null)
        {
           
            // Play the timeline
            playableDirector.Play();
        }
    }



    void StopTimeline()
    {
        if (playableDirector != null)
        {
           
            playableDirector.Stop();
            // Destroy(OccamyKronkel);


        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class TimelineControl : MonoBehaviour
{

    public PlayableDirector playableDirector;  // Reference to Playable Director
    public Button playButton;                  // Reference to the play button
    public Button stopButton;                  // Reference to the stop button
   

    void Start()
    {
        // Add listeners to buttons to play or stop the timeline when clicked
        playButton.onClick.AddListener(PlayTimeline);
        stopButton.onClick.AddListener(StopTimeline);
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
            // Stop the timeline (it will reset to the first frame)
            playableDirector.Stop();
            
        }
    }
}

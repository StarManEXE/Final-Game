using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioStart : MonoBehaviour
{
    public GameObject objectToEnable; // The object to enable once the video is done playing

    private VideoPlayer videoPlayer;

    private void Start()
    {
        // Get the VideoPlayer component attached to the object playing the video
        videoPlayer = GetComponent<VideoPlayer>();

        // Subscribe to the "loopPointReached" event to know when the video has ended
        videoPlayer.loopPointReached += EnableObjectAtEnd;
    }

    private void EnableObjectAtEnd(VideoPlayer vp)
    {
        // Enable the object once the video has finished playing
        objectToEnable.SetActive(true);
    }
}

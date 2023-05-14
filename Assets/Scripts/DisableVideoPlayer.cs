using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DisableVideoPlayer : MonoBehaviour
{
    public Canvas canvas;
    public VideoPlayer videoPlayer;

    private void Start()
    {
        // Subscribe to the "loopPointReached" event to know when the video has ended
        videoPlayer.loopPointReached += DisableCanvasObjectAtEnd;
    }

    private void DisableCanvasObjectAtEnd(VideoPlayer vp)
    {
        // Disable the Canvas component when the video has finished playing
        canvas.enabled = false;
    }
}

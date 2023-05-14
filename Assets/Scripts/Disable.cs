using UnityEngine;
using UnityEngine.Video;

public class Disable : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.loopPointReached += DisableVideoPlayerAtEnd;
    }

    private void DisableVideoPlayerAtEnd(VideoPlayer vp)
    {
        videoPlayer.enabled = false;
    }
}

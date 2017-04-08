using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    public Texture play;
    public Texture pause;
    Transform videoButton;
    VideoPlayer vPlayer;
    VideoPlayer[] videos;
    void Start()
    {
        vPlayer = gameObject.GetComponent<VideoPlayer>();
        videoButton = transform.FindChild("Button");
        videos = GameObject.FindObjectsOfType<VideoPlayer>();
    }

    public void PlayVideo()
    {
        if (!vPlayer.isPlaying)
        {
            StopAll();
            videoButton.gameObject.SetActive(false);
            vPlayer.Play();
        }
        else
        {
            videoButton.GetComponent<Renderer>().material.mainTexture = play;
            videoButton.gameObject.SetActive(true);
            vPlayer.Pause();
        }
    }
    void StopAll()
    {
        for (int i = 0; i < videos.Length; i++)
        {
            videos[i].Pause();
            videos[i].transform.FindChild("Button").gameObject.SetActive(true);
        }
    }
}

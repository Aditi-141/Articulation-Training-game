using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip StartClip;
    public AudioClip LoopClip;
    private AudioClip clip;
    internal static bool isPlaying;
    internal static float volume;
    internal static AudioClip clips;

    void Start()
    {
        StartCoroutine(playSound());
    }

    IEnumerator playSound()
    {
        GetComponent<AudioSource>().clip = StartClip;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(StartClip.length);
        GetComponent<AudioSource>().clip = LoopClip;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }

    internal static void Stop()
    {
        throw new NotImplementedException();
    }

    internal static void Play()
    {
        throw new NotImplementedException();
    }
}


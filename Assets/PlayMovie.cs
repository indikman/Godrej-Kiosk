﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PlayMovie : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource audio;

	// Use this for initialization
	void Awake () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
	}

    public void PlayVideo() {
        movie.Play();
        audio.Play();
    }

    public void StopVideo() {
        movie.Stop();
        audio.Stop();
    }
}

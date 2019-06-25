using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SympleAudioManager : MonoBehaviour {

    [Header("Audio Sources")]
    public List<AudioSource> FXSources;
    private int fxSourcesIndex;
    public AudioSource MusicSources;
    

    [Header("Audio Clips Music")]
    public AudioClip MusicMenuClip;
    public AudioClip MusicGameplayClip;

    [Header("Audio Clips FX")]
    public AudioClip FXClip1;

    public void PlayMenuMusic() {
        MusicSources.clip = MusicMenuClip;
        MusicSources.Play();
    }

    public void PlayGameplayMusic() {
        MusicSources.clip = MusicGameplayClip;
        MusicSources.Play();
    }

    public void PlayFX1() {
        FXSources[fxSourcesIndex].clip = FXClip1;
        FXSources[fxSourcesIndex].Play();
        fxSourcesIndex++;
        if (fxSourcesIndex >= FXSources.Count)
            fxSourcesIndex = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    [Header("---------- Audio Clip ----------")]
    public AudioClip Gamebackground;
    public AudioClip gunshoot;
    public AudioClip Eat;
    public AudioClip Buy;
    public AudioClip Death;
    public AudioClip Hit;
    public AudioClip enemyDeath;
    public AudioClip BtnClick;

    private void Start() {
        musicSource.clip = Gamebackground;
        musicSource.Play();
    }

    public void SetMusicVolume(float volume) {
        musicSource.volume = volume;
    }

    public void SetSFXVolume(float volume) {
        SFXSource.volume = volume;
    }

    public void PlaySFX(AudioClip clip) {
        SFXSource.PlayOneShot(clip);
    }


}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemaMusicManager : MonoBehaviour
{
    private bool isMusicMute = false;
    public AudioClip mainMusic;

    public AudioSource audioSource;
    private static CinemaMusicManager instance;
    public static CinemaMusicManager Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        audioSource = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("isMusicMute", 0) == 1)
        {
            isMusicMute = true;
        }
        else
        {
            isMusicMute = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = mainMusic;
        audioSource.Play();
    }
    public void stopMusic()
    {
        //if (isMusicMute == true)
        
            audioSource.Stop();
        
        //else audioSource.Play();
    }
    // Update is called once per frame
    void Update()
    {

        if (isMusicMute)
        {
            audioSource.volume = 0;
        }
        else if (!isMusicMute)
        {
            audioSource.volume = 0.8f;
        }
    }
    public void ClickMusicMute()
    {
        if (!isMusicMute)
        {
            // 음소거 아닐때
            PlayerPrefs.SetInt("isMusicMute", 1);
            isMusicMute = true;
            audioSource.Stop();
        }
        else
        {
            PlayerPrefs.SetInt("isMusicMute", 0);
            isMusicMute = false;
            audioSource.Play();
        }
    }
}
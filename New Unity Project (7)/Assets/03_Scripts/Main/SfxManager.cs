﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    private bool isMute = false;

    public AudioClip click, back, wrong, check;
    
    private AudioSource audioSource;
    
    private static SfxManager instance;
    public static SfxManager Instance
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
    }

    public void playClick()
    {
        if (!isMute)
        {
            audioSource.clip = click;
            audioSource.Play();    
        }
    }
    
    public void playBack()
    {
        if (!isMute)
        {
            audioSource.clip = back;
            audioSource.Play();    
        }
    }
    
    public void playWrong()
    {
        if (!isMute)
        {
            audioSource.clip = wrong;
            audioSource.Play();    
        }
    }

    public void playCheck()
    {
        if (!isMute)
        {
            audioSource.clip = check;
            audioSource.Play();    
        }
    }

    public bool getIsMute()
    {
        return isMute;
    }

    public void setIsMute(bool isMute)
    {
        this.isMute = isMute;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashierSfxManager : MonoBehaviour
{
    private bool isMute = false;

    public AudioClip scanner, click, back;
    
    private AudioSource audioSource;
    
    private static CashierSfxManager instance;
    public static CashierSfxManager Instance
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

    public void clickMute()
    {
        isMute = !isMute;
    }

    public void playScanner()
    {
        if (!isMute)
        {
            audioSource.clip = scanner;
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
    
    public void playClick()
    {
        if (!isMute)
        {
            audioSource.clip = click;
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

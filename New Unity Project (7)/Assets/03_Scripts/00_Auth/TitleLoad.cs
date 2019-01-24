﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        switch (Application.loadedLevel)
        {
            
            case 2:
                // up
            case 3:
            case 4:
                Destroy(gameObject);
                break;
            default:
                return;
        }
    }
}

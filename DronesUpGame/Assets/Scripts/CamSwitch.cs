﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject fpp;
    public GameObject tpp;
    public AudioListener fppAudioListener;
    public AudioListener tppAudioListener;
    public bool isFPPOn = false;
    

    // The if checks wether the camera is in first-person or third-person and it swaps to the other one accordingly
    void Update()
    {
        if (Input.GetButtonDown("Camera") && !isFPPOn)
        {
            fpp.SetActive(true);
            tpp.SetActive(false);
            fppAudioListener.enabled = true;
            tppAudioListener.enabled = false;
            isFPPOn = true;
        }
        else if(Input.GetButtonDown("Camera") && isFPPOn)
        {
            fpp.SetActive(false);
            tpp.SetActive(true);
            fppAudioListener.enabled = false;
            tppAudioListener.enabled = true;
            isFPPOn = false;
        }

    }
}

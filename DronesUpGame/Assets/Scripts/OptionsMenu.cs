using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
//Options menu allows the user to adjust the value based on their preferences
public class OptionsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
   public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume*2);
        //Debug.Log(volume);
    }
}

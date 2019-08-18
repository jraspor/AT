using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SoundOff()
    {
        GameObject temp = GameObject.Find("Volume Slider");
        audioMixer.SetFloat("volume", -50);
        slider = temp.GetComponent<Slider>();
        slider.value = -50;
    }
    
    public void SoundOn()
    {
        GameObject temp = GameObject.Find("Volume Slider");
        audioMixer.SetFloat("volume", 0);
        slider = temp.GetComponent<Slider>();
        slider.value = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;

   /* private void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
        }

        resolutionDropdown.AddOptions(options);
    }*/

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

   /* public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    } */
}

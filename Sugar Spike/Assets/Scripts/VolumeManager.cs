using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Audio"))
        {
            PlayerPrefs.SetFloat("Audio", 1);
            LoadSettings();
        }
        else
        {
            LoadSettings();
        }
    }

    // Update is called once per frame
   public void AdjustVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveSettings();
    }
    public void LoadSettings()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Audio");
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("Audio", volumeSlider.value);
    }
}

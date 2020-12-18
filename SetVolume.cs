using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetVolume : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider slider, masterslider;


    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("sfx");
        masterslider.value = PlayerPrefs.GetFloat("master");

    }
      
    public void SetLevel()
    {
        float sliderValueSFX = slider.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValueSFX) * 20);
    }
    void Update()
    {
        

        float sliderValueSFX = slider.value;
        float slidermaster = masterslider.value;
        if (slider.value > masterslider.value)
        {
            slider.value = masterslider.value;
        }
        else;

        PlayerPrefs.SetFloat("sfx", slider.value);
        PlayerPrefs.SetFloat("master", masterslider.value);

        

    }

    


}
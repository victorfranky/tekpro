using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetVolumeBGM : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider slider, masterslider;
    


    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("bgm");
        masterslider.value = PlayerPrefs.GetFloat("master");
      
    }

    public void SetLevel()
    {
        float sliderValueBGM = slider.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValueBGM) * 20);
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

        PlayerPrefs.SetFloat("bgm", slider.value);
        PlayerPrefs.SetFloat("master", masterslider.value);



    }




}
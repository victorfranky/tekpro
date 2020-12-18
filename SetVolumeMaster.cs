using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class SetVolumeMaster : MonoBehaviour
{
    public Slider master;
    
void Start()
    {
        master.value = PlayerPrefs.GetFloat("master");
    }



}
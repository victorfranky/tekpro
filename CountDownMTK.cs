using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownMTK : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    public GameObject KehabisanWaktu;


    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {

            KehabisanWaktu.SetActive(true);

        }

    }



}

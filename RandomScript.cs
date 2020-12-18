using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour

{

    public GameObject[] Question;
    int index;
    void Start()
    {

        index = Random.Range(0, Question.Length);
        Question[index].SetActive(true);
    }

        }
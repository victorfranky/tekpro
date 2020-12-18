using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class TRACKTUTORIAL : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{ 

    public VideoPlayer tutorial;
    Slider track;
    bool slide = false;
    // Start is called before the first frame update
    void Start()
    {
        track = GetComponent<Slider> ();
    }

    public void OnPointerDown(PointerEventData a)
    {
        slide = true;
    }

    public void OnPointerUp(PointerEventData a)
    {
        float frame = (float)track.value * (float)tutorial.frameCount;
        tutorial.frame = (long)frame;
        slide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!slide && tutorial.isPlaying)
        {
            track.value = (float)tutorial.frame / (float)tutorial.frameCount;
        }
        
    }
}

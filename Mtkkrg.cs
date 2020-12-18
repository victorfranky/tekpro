using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Mtkkrg : MonoBehaviour
{

    public GameObject letterOne, letterTwo, letterThree, letterFor, letterFive, letterSix, BoxOne;

    Vector3 letterOneIni, letterTwoIni, letterThreeIni, letterForIni, letterFiveIni, letterSixIni;



    string str = "";
    public string word;



    bool oneCorrect, twoCorrect, threeCorrect, forCorrect, fiveCorrect, sixCorrect = false;

    Vector3 iniScaleletterOne, iniScaleletterTwo, iniScaleletterThree, iniScaleletterFor, iniScaleletterFive, iniScaleletterSix;


    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip buttonDrop;
    public AudioClip reload;


    void Start()
    {


        letterOneIni = letterOne.transform.position;
        letterTwoIni = letterTwo.transform.position;
        letterThreeIni = letterThree.transform.position;
        letterForIni = letterFor.transform.position;
        letterFiveIni = letterFive.transform.position;
        letterSixIni = letterSix.transform.position;


        iniScaleletterOne = letterOne.transform.localScale;
        iniScaleletterTwo = letterTwo.transform.localScale;
        iniScaleletterThree = letterThree.transform.localScale;
        iniScaleletterFor = letterFor.transform.localScale;
        iniScaleletterFive = letterFive.transform.localScale;
        iniScaleletterSix = letterSix.transform.localScale;



        // blockPanel.SetActive(false);

    }




    //*****************************************Drag

    public void DragletterOne()
    {
        letterOne.transform.position = Input.mousePosition;
    }
    public void DragletterTwo()
    {
        letterTwo.transform.position = Input.mousePosition;
    }
    public void DragletterThree()
    {
        letterThree.transform.position = Input.mousePosition;
    }
    public void DragletterFor()
    {
        letterFor.transform.position = Input.mousePosition;
    }
    public void DragletterFive()
    {
        letterFive.transform.position = Input.mousePosition;
    }
    public void DragletterSix()
    {
        letterSix.transform.position = Input.mousePosition;
    }






    //****************************************Drop


    public void DropletterOne()
    {
        float Distance = Vector3.Distance(letterOne.transform.position, BoxOne.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            letterOne.transform.localScale = BoxOne.transform.localScale;
            letterOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();

        }

        else
        {
            letterOne.transform.position = letterOneIni;
            source.clip = reload;
            source.Play();
        }

    }



    public void DropletterTwo()
    {
        float Distance = Vector3.Distance(letterTwo.transform.position, BoxOne.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            letterTwo.transform.localScale = BoxOne.transform.localScale;
            letterTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterTwo.transform.position = letterTwoIni;
            source.clip = reload;
            source.Play();
        }

    }




    public void DropletterThree()
    {
        float Distance = Vector3.Distance(letterThree.transform.position, BoxOne.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            letterThree.transform.localScale = BoxOne.transform.localScale;
            letterThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterThree.transform.position = letterThreeIni;
            source.clip = reload;
            source.Play();
        }

    }


    public void DropletterFor()
    {
        float Distance = Vector3.Distance(letterFor.transform.position, BoxOne.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            letterFor.transform.localScale = BoxOne.transform.localScale;
            letterFor.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterFor.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            letterFor.transform.position = letterForIni;
            source.clip = reload;
            source.Play();
        }

    }


    public void DropletterFive()
    {
        float Distance = Vector3.Distance(letterFive.transform.position, BoxOne.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            letterFive.transform.localScale = BoxOne.transform.localScale;
            letterFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterFive.transform.position = letterFiveIni;
            source.clip = reload;
            source.Play();
        }

    }


    public void DropletterSix()
    {
        float Distance = Vector3.Distance(letterSix.transform.position, BoxOne.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            letterSix.transform.localScale = BoxOne.transform.localScale;
            letterSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            letterSix.transform.position = letterSixIni;
            source.clip = reload;
            source.Play();
        }

    }








    //Button
    public GameObject[] Question;
    int index;

    public void Check()
    {


        str = BoxOne.name;

        if (word == str)
        {
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            StartCoroutine(Delay());


        }
        else
        {
            source.clip = incorrect;
            source.Play();

        }

    }

    public void Reload()
    {
        str = "";


        source.clip = reload;
        source.Play();

        oneCorrect = false;


        BoxOne.name = "Fill";



        letterOne.transform.position = letterOneIni;
        letterTwo.transform.position = letterTwoIni;
        letterThree.transform.position = letterThreeIni;
        letterFor.transform.position = letterForIni;
        letterFive.transform.position = letterFiveIni;
        letterSix.transform.position = letterSixIni;


        letterOne.transform.localScale = iniScaleletterOne;
        letterTwo.transform.localScale = iniScaleletterTwo;
        letterThree.transform.localScale = iniScaleletterThree;
        letterFor.transform.localScale = iniScaleletterFor;
        letterFive.transform.localScale = iniScaleletterFive;
        letterSix.transform.localScale = iniScaleletterSix;



    }



    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);

        str = "";
        oneCorrect = false;


        BoxOne.name = "Fill";


        letterOne.transform.position = letterOneIni;
        letterTwo.transform.position = letterTwoIni;
        letterThree.transform.position = letterThreeIni;
        letterFor.transform.position = letterForIni;
        letterFive.transform.position = letterFiveIni;
        letterSix.transform.position = letterSixIni;


        letterOne.transform.localScale = iniScaleletterOne;
        letterTwo.transform.localScale = iniScaleletterTwo;
        letterThree.transform.localScale = iniScaleletterThree;
        letterFor.transform.localScale = iniScaleletterFor;
        letterFive.transform.localScale = iniScaleletterFive;
        letterSix.transform.localScale = iniScaleletterSix;


        index = Random.Range(0, 11);
        Question[12].SetActive(false);
        Question[index].SetActive(true);
        ScoreScriptMinus.scoreValue += 10;
    }

}

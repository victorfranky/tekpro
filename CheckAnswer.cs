using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class CheckAnswer : MonoBehaviour
{

    public GameObject letterOne, letterTwo, letterThree, letterFor, letterFive, letterSix, letterSeven, 
                      letterEight, letterNine, letterTen, BoxOne, BoxTwo, BoxThree, BoxFor, BoxFive, BoxSix;

    Vector3 letterOneIni, letterTwoIni, letterThreeIni, letterForIni, letterFiveIni, letterSixIni, letterSevenIni, letterEightIni, letterNineIni, letterTenIni;
         
              

    string str = "";
    public string word;

    

    bool oneCorrect, twoCorrect, threeCorrect, forCorrect, fiveCorrect, sixCorrect = false;

    Vector3 iniScaleletterOne, iniScaleletterTwo, iniScaleletterThree, iniScaleletterFor, iniScaleletterFive, iniScaleletterSix,
            iniScaleletterSeven, iniScaleletterEight, iniScaleletterNine, iniScaleletterTen;

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
        letterSevenIni = letterSeven.transform.position;
        letterEightIni = letterEight.transform.position;
        letterNineIni = letterNine.transform.position;
        letterTenIni = letterTen.transform.position;

        iniScaleletterOne = letterOne.transform.localScale;
        iniScaleletterTwo = letterTwo.transform.localScale;
        iniScaleletterThree = letterThree.transform.localScale;
        iniScaleletterFor = letterFor.transform.localScale;
        iniScaleletterFive = letterFive.transform.localScale;
        iniScaleletterSix = letterSix.transform.localScale;
        iniScaleletterSeven = letterSeven.transform.localScale;
        iniScaleletterEight = letterEight.transform.localScale;
        iniScaleletterNine = letterNine.transform.localScale;
        iniScaleletterTen = letterTen.transform.localScale;

        
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
    public void DragLettrSeven()
    {
        letterSeven.transform.position = Input.mousePosition;
    }
    public void DragletterEight()
    {
        letterEight.transform.position = Input.mousePosition;
    }
    public void DragletterNine()
    {
        letterNine.transform.position = Input.mousePosition;
    }
    public void DragletterTen()
    {
        letterTen.transform.position = Input.mousePosition;
    }





    //****************************************Drop


    public void DropletterOne()
    {
        float Distance = Vector3.Distance(letterOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterOne.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterOne.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterOne.transform.position, BoxSix.transform.position);

        if (Distance < 70 && oneCorrect == false)
        {
            letterOne.transform.localScale = BoxOne.transform.localScale;
            letterOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterOne.transform.localScale = BoxTwo.transform.localScale;
            letterOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterOne.transform.localScale = BoxThree.transform.localScale;
            letterOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterOne.transform.localScale = BoxFor.transform.localScale;
            letterOne.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterOne.transform.localScale = BoxFive.transform.localScale;
            letterOne.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterOne.transform.localScale = BoxSix.transform.localScale;
            letterOne.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterOne.name;
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
        float Distance2 = Vector3.Distance(letterTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterTwo.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterTwo.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterTwo.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterTwo.transform.localScale = BoxOne.transform.localScale;
            letterTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterTwo.transform.localScale = BoxTwo.transform.localScale;
            letterTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterTwo.transform.localScale = BoxThree.transform.localScale;
            letterTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterTwo.transform.localScale = BoxFor.transform.localScale;
            letterTwo.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();

        }

        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterTwo.transform.localScale = BoxFive.transform.localScale;
            letterTwo.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterTwo.transform.localScale = BoxSix.transform.localScale;
            letterTwo.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterTwo.name;
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
        float Distance2 = Vector3.Distance(letterThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterThree.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterThree.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterThree.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterThree.transform.localScale = BoxOne.transform.localScale;
            letterThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterThree.transform.localScale = BoxTwo.transform.localScale;
            letterThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterThree.transform.localScale = BoxThree.transform.localScale;
            letterThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterThree.transform.localScale = BoxFor.transform.localScale;
            letterThree.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterThree.transform.localScale = BoxFive.transform.localScale;
            letterThree.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterThree.transform.localScale = BoxSix.transform.localScale;
            letterThree.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterThree.name;
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
        float Distance2 = Vector3.Distance(letterFor.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterFor.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterFor.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterFor.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterFor.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterFor.transform.localScale = BoxOne.transform.localScale;
            letterFor.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterFor.transform.localScale = BoxTwo.transform.localScale;
            letterFor.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterFor.transform.localScale = BoxThree.transform.localScale;
            letterFor.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterFor.transform.localScale = BoxFor.transform.localScale;
            letterFor.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterFor.transform.localScale = BoxFive.transform.localScale;
            letterFor.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterFor.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterFor.transform.localScale = BoxSix.transform.localScale;
            letterFor.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterFor.name;
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
        float Distance2 = Vector3.Distance(letterFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterFive.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterFive.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterFive.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterFive.transform.localScale = BoxOne.transform.localScale;
            letterFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterFive.transform.localScale = BoxTwo.transform.localScale;
            letterFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterFive.transform.localScale = BoxThree.transform.localScale;
            letterFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterFive.transform.localScale = BoxFor.transform.localScale;
            letterFive.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterFive.transform.localScale = BoxFive.transform.localScale;
            letterFive.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterFive.transform.localScale = BoxSix.transform.localScale;
            letterFive.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterFive.name;
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
        float Distance2 = Vector3.Distance(letterSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterSix.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterSix.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterSix.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterSix.transform.localScale = BoxOne.transform.localScale;
            letterSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterSix.transform.localScale = BoxTwo.transform.localScale;
            letterSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterSix.transform.localScale = BoxThree.transform.localScale;
            letterSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            source.clip = buttonDrop;
            source.Play();
            BoxThree.name = letterSix.name;
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterSix.transform.localScale = BoxFor.transform.localScale;
            letterSix.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterSix.transform.localScale = BoxFive.transform.localScale;
            letterSix.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterSix.transform.localScale = BoxSix.transform.localScale;
            letterSix.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterSix.name;
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



    public void DropletterSeven()
    {
        float Distance = Vector3.Distance(letterSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterSeven.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterSeven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterSeven.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterSeven.transform.localScale = BoxOne.transform.localScale;
            letterSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterSeven.transform.localScale = BoxTwo.transform.localScale;
            letterSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterSeven.transform.localScale = BoxThree.transform.localScale;
            letterSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterSeven.transform.localScale = BoxFor.transform.localScale;
            letterSeven.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterSeven.transform.localScale = BoxFive.transform.localScale;
            letterSeven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterSeven.transform.localScale = BoxSix.transform.localScale;
            letterSeven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterSeven.transform.position = letterSevenIni;
            source.clip = reload;
            source.Play();
        }

    }


    public void DropletterEight()
    {
        float Distance = Vector3.Distance(letterEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterEight.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterEight.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterEight.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterEight.transform.localScale = BoxOne.transform.localScale;
            letterEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterEight.transform.localScale = BoxTwo.transform.localScale;
            letterEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterEight.transform.localScale = BoxThree.transform.localScale;
            letterEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterEight.transform.localScale = BoxFor.transform.localScale;
            letterEight.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterEight.transform.localScale = BoxFive.transform.localScale;
            letterEight.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterEight.transform.localScale = BoxSix.transform.localScale;
            letterEight.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterEight.transform.position = letterEightIni;
            source.clip = reload;
            source.Play();
        }

    }
    public void DropletterNine()
    {
        float Distance = Vector3.Distance(letterNine.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterNine.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterNine.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterNine.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterNine.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterNine.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterNine.transform.localScale = BoxOne.transform.localScale;
            letterNine.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterNine.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterNine.transform.localScale = BoxTwo.transform.localScale;
            letterNine.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterNine.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterNine.transform.localScale = BoxThree.transform.localScale;
            letterNine.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterNine.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterNine.transform.localScale = BoxFor.transform.localScale;
            letterNine.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterNine.name;
            source.clip = buttonDrop;
            source.Play();

        }

        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterNine.transform.localScale = BoxFive.transform.localScale;
            letterNine.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterNine.transform.localScale = BoxSix.transform.localScale;
            letterNine.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterNine.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            letterNine.transform.position = letterNineIni;
            source.clip = reload;
            source.Play();
        }

    }
    public void DropletterTen()
    {
        float Distance = Vector3.Distance(letterTen.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterTen.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterTen.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterTen.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(letterTen.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(letterTen.transform.position, BoxSix.transform.position);
        if (Distance < 70 && oneCorrect == false)
        {
            letterTen.transform.localScale = BoxOne.transform.localScale;
            letterTen.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterTen.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 70 && twoCorrect == false)
        {
            letterTen.transform.localScale = BoxTwo.transform.localScale;
            letterTen.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterTen.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 70 && threeCorrect == false)
        {
            letterTen.transform.localScale = BoxThree.transform.localScale;
            letterTen.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterTen.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 70 && forCorrect == false)
        {
            letterTen.transform.localScale = BoxFor.transform.localScale;
            letterTen.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = letterTen.name;
            source.clip = buttonDrop;
            source.Play();

        }

        else if (Distance5 < 70 && fiveCorrect == false)
        {
            letterTen.transform.localScale = BoxFive.transform.localScale;
            letterTen.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = letterTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 70 && sixCorrect == false)
        {
            letterTen.transform.localScale = BoxSix.transform.localScale;
            letterTen.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = letterTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterTen.transform.position = letterTenIni;
            source.clip = reload;
            source.Play();
        }

    }






    //Button
    public GameObject[] Question;
    int index;

    public void Check()
    {


        str = BoxOne.name + BoxTwo.name + BoxThree.name + BoxFor.name + BoxFive.name + BoxSix.name;

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
        twoCorrect = false;
        threeCorrect = false;
        forCorrect = false;
        fiveCorrect = false;
        sixCorrect = false;

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFor.name = "4";
        BoxFive.name = "5";
        BoxSix.name = "6";


        letterOne.transform.position = letterOneIni;
        letterTwo.transform.position = letterTwoIni;
        letterThree.transform.position = letterThreeIni;
        letterFor.transform.position = letterForIni;
        letterFive.transform.position = letterFiveIni;
        letterSix.transform.position = letterSixIni;
        letterSeven.transform.position = letterSevenIni;
        letterEight.transform.position = letterEightIni;
        letterNine.transform.position = letterNineIni;
        letterTen.transform.position = letterTenIni;

        letterOne.transform.localScale = iniScaleletterOne;
        letterTwo.transform.localScale = iniScaleletterTwo;
        letterThree.transform.localScale = iniScaleletterThree;
        letterFor.transform.localScale = iniScaleletterFor;
        letterFive.transform.localScale = iniScaleletterFive;
        letterSix.transform.localScale = iniScaleletterSix;
        letterSeven.transform.localScale = iniScaleletterSeven;
        letterEight.transform.localScale = iniScaleletterEight;
        letterNine.transform.localScale = iniScaleletterNine;
        letterTen.transform.localScale = iniScaleletterTen;



    }

   

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);

        str = "";
        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        forCorrect = false;
        fiveCorrect = false;
        sixCorrect = false;

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFor.name = "4";
        BoxFive.name = "5";
        BoxSix.name = "6";


        letterOne.transform.position = letterOneIni;
        letterTwo.transform.position = letterTwoIni;
        letterThree.transform.position = letterThreeIni;
        letterFor.transform.position = letterForIni;
        letterFive.transform.position = letterFiveIni;
        letterSix.transform.position = letterSixIni;
        letterSeven.transform.position = letterSevenIni;
        letterEight.transform.position = letterEightIni;
        letterNine.transform.position = letterNineIni;
        letterTen.transform.position = letterTenIni;

        letterOne.transform.localScale = iniScaleletterOne;
        letterTwo.transform.localScale = iniScaleletterTwo;
        letterThree.transform.localScale = iniScaleletterThree;
        letterFor.transform.localScale = iniScaleletterFor;
        letterFive.transform.localScale = iniScaleletterFive;
        letterSix.transform.localScale = iniScaleletterSix;
        letterSeven.transform.localScale = iniScaleletterSeven;
        letterEight.transform.localScale = iniScaleletterEight;
        letterNine.transform.localScale = iniScaleletterNine;
        letterTen.transform.localScale = iniScaleletterTen;

        index = Random.Range(0, 8);
        Question[9].SetActive(false);
        Question[index].SetActive(true);
        ScoreScriptEN.scoreValue += 10;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    public GameObject DisplayBox;
    public GameObject PassBox;
    public GameManager GameManager;

    public int QTEGen;
    public int WaitingForKey;
    public int CorrectKey;
    public int CountingDone;
    public int win;

    private void Start()
    {
        win= 0;
        QTEGen = Random.Range(1, 4);
        GameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
    }

    void Update()
    {
        if (win >= 5)
        {

            Debug.Log("win");
            GameManager.NextGame();
        }

        if (WaitingForKey == 0)
        {     
            if (QTEGen == 1)
            {
                DisplayBox.GetComponent<Text>().text = "[E]";
            }
            if (QTEGen == 2)
            {
                DisplayBox.GetComponent<Text>().text = "[R]";
            }
            if (QTEGen == 3)
            {
                DisplayBox.GetComponent<Text>().text = "[T]";
            }

            if (QTEGen == 1)
            {
                if (Input.anyKeyDown && (!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)))
                {

                    if (Input.GetButtonDown("E"))
                    {

                        CorrectKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        CorrectKey = 2;
                        StartCoroutine(KeyPressing());
                    }

                }
            }
            if (QTEGen == 2)
            {
                if (Input.anyKeyDown && (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S)))
                {
                    if (Input.GetButtonDown("R"))
                    {

                        CorrectKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        CorrectKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                }
            }
            if (QTEGen == 3)
            {
                if (Input.anyKeyDown && (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S)))
                {
                    if (Input.GetButtonDown("T"))
                    {

                        CorrectKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        CorrectKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                }
            }
           
        }
    }

    IEnumerator KeyPressing()
    {
        //QTEGen = 4;
        if (CorrectKey == 1)
        {
            CountingDone = 2;
            PassBox.GetComponent<Text>().text = "PASS!";
            yield return new WaitForSeconds(1f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            WaitingForKey = 1;
            yield return new WaitForSeconds(0.3f);
            WaitingForKey = 0;
            QTEGen = Random.Range(1, 4);
            win += 1;
        }
    }
    IEnumerator CountDown()
    {
        if (CountingDone == 1)
        {
            QTEGen = 4;
           CountingDone = 2;
            PassBox.GetComponent<Text>().text = "Fail";
            yield return new WaitForSeconds(1f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(0.3f);
            WaitingForKey = 0;
            CountingDone = 1;

        }
    }

}


 



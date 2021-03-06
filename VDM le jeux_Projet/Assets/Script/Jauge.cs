﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jauge : MonoBehaviour
{
    public Slider JaugeVise;
    public TransitionScreen GameManager;
    public Animator AnimatorCatapulte;
    public Animator Dechet;
    public Animator Soleil;
    public Animator Nuage;
    public Animator Nuage2;
    public float i = 0;
    public bool IsUp = false;
    public bool Stop = false;

	// Use this for initialization
	void Start ()
    {
        JaugeVise.value = i;
        GameManager = GameObject.Find("Transition Screen").GetComponent<TransitionScreen>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Stop == false)
        {
            Boucle();
        }
	}


    //fais la boucle de gauche a droite
    void Boucle()
    {
        if (Stop == false)
        {
            if (i >= 1)
            {
                IsUp = false;
            }
            if (i <= 0)
            {
                IsUp = true;
            }
            if (IsUp == false)
            {
                i -= 0.03F;
                JaugeVise.value = i;
            }
            if (IsUp == true)
            {
                i += 0.03F;
                JaugeVise.value = i;

            }

            if (Input.GetKeyDown("space"))
            {
                Stop = true;
                AnimatorCatapulte.SetBool("Lanch", true);

            }
        }

        if (i >= 0.4 && i <= 0.6 && Stop == true)
        {
            Dechet.SetTrigger("WinLanch");
            print("win !");
            EndGame();
        }
        else if (Stop == true)
        {
            print("lose !");
            Dechet.SetTrigger("LoseLanch");
            Nuage.SetTrigger("Lose");
            Nuage2.SetTrigger("Lose");
            Soleil.SetTrigger("Lose");
            EndGame();
        }
    }

    void EndGame()
    {
        if(Stop== true)
        {
            GameManager.EndGame();
            print("endgame");
        }
    }
}

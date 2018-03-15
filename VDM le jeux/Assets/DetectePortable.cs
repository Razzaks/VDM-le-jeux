﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectePortable : MonoBehaviour {

    public GameObject smiley;
    public GameObject scolere;
    public GameManager GameManager;

    private bool encolere;

	// Use this for initialization
	void Start ()
    {
        encolere = false;
        scolere.SetActive(false);
        GameManager = GameObject.Find("Canvas").GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
        if (encolere == true)
        {
            scolere.SetActive(true);
            smiley.SetActive(false);
        }
        if (encolere == false)
        {
            scolere.SetActive(false);
            smiley.SetActive(true);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Portable"))
        {
            encolere = true;
            GameManager.NextGame();
            print("lol");
        }
    }
}

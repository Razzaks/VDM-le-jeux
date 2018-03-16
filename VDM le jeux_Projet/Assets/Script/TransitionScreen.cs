using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScreen : MonoBehaviour {

    public GameObject[] TransitionScreens;
    public GameManager gameManager;
    public bool fail = false;
    private int iii = 0;

	// Use this for initialization
	void Start ()
    {
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EndGame()
    {
        StartCoroutine(Transition());
        print("lance le endgame");
    }

    IEnumerator Transition()
    {
        yield return new WaitForSeconds(3);
        print("affiche la transition");

        //fail screen
        if (fail == true)
        {
            TransitionScreens[1].SetActive(true);
            iii = 1;
        }
        //win screen
        else
        {
            TransitionScreens[0].SetActive(true);
            iii = 0;
        }
        //on passe au jeu suivant
        yield return new WaitForSeconds(3);
        TransitionScreens[iii].SetActive(false);
        gameManager.NextGame();
        print("passe la transition");
    }
}

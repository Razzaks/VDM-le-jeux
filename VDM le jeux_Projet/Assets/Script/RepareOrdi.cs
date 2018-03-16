using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepareOrdi : MonoBehaviour {

    private int[] bug;
    private int i;
    private int ii = 0;
    public GameObject[] direction;
    public TransitionScreen GameManager;
    public Animator[] Punch;
    public bool wait = false;

	// Use this for initialization
	void Start ()
    {
        Bug();
        GameManager = GameObject.Find("Transition Screen").GetComponent<TransitionScreen>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Punching();
        Fixing();
	}

    void Bug()
    {
        wait = false;
        i = Random.Range(0,3);
        direction[i].SetActive(true);
    }

    //indique où on doit "réparer"
    void Fixing()
    {
        //droite
        if (i == 0)
        {
            //demande la bonne touche

            //victoire
            if (direction[0] && Input.GetKeyDown("right"))
            {
                direction[i].SetActive(false);
                StartCoroutine(WaitSucess());
            }

            if (wait == true)
            {
                Bug();
                print("yeah");
            }

            //défaite
            else if (Input.GetKeyDown("down") || Input.GetKeyDown("left"))
            {
                EndGame();
                print("fail left");
                //DEFAITE
            }
        }

        //gauche
        if (i == 1)
        {
            if (direction[1] && Input.GetKeyDown("left"))
            {
                direction[i].SetActive(false);
                StartCoroutine(WaitSucess());
            }

            if (wait == true)
            {
                Bug();
                print("yeah");
            }

            else if (Input.GetKeyDown("right") || Input.GetKeyDown("down"))
            {
                EndGame();
                print("fail right");
                //DEFAITE
            }
        }

        //bas
        if (i == 2)
        {
            if (direction[2] && Input.GetKeyDown("down"))
            {
                direction[i].SetActive(false);
                StartCoroutine(WaitSucess());
            }

            if (wait == true)
            {
                Bug();
                print("yeah");
            }

            else if (Input.GetKeyDown("left") || Input.GetKeyDown("right"))
            {
                EndGame();
                print("fail down");
                //DEFAITE
            }
        }
    }

    //transition entre deux bugs
    IEnumerator WaitSucess()
    {
        //incrémente l la victoire
        ii++;
        Debug.Log(ii);
        if (ii == 3)
        {
            EndGame();
            //VICTOIRE !!
        }
        yield return new WaitForSeconds(Random.Range(1,2));
        wait = true;
        print("okay !");
    }

    //lance les animation
    void Punching()
    {
        if (Input.GetKeyDown("right"))
        {
            Punch[0].SetTrigger("Punch");
        }

        if (Input.GetKeyDown("left"))
        {
            Punch[1].SetTrigger("Punch");
        }

        if (Input.GetKeyDown("down"))
        {
            Punch[2].SetTrigger("Punch");
        }

    }

    void EndGame()
    {
        GameManager.EndGame();
        print("End Game");
    }
}

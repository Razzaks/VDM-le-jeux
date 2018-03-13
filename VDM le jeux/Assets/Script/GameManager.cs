using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int[] miniJeux;
    private bool[] passage;
    private int i = 0;
    private int ii = 0;

	// Use this for initialization
	void Start ()
    {
        i= Random.Range(0, 4);
        passage = new bool[miniJeux.Length];
        for(int i = 0; i<passage.Length;++i)
        {
            passage[i] = false;
        }
        ChangeGame();
	}

	// Update is called once per frame
	void Update ()
    {

	}

    //je regarde si tous les mini jeux sont jouer

    bool IsOnlyTrue()
    {
        bool result = true;

        for(int i = 0; i < passage.Length; ++i)
        {
            if(passage[i]== false)
            {
                result = false;
            } 
        }
        return result;
    }

    //si tous les mini jeux ont été joués
    //on ne choisi pas un nouveau jeux

    public void NextGame()
    {
        if (IsOnlyTrue() == false)
        {
            //miniJeux[ii].SetActive(false);
            SceneManager.UnloadSceneAsync(ii);
            do
            {
                i = Random.Range(0, 4);
            } while (passage[i] == true);

            ChangeGame();
        }
        else
        {
            print("le boss");
        }
    }

    void ChangeGame()
    {
        //miniJeux[i].SetActive(true);
        SceneManager.LoadScene(i, LoadSceneMode.Additive);
        passage[i] = true;
        ii = i;
        Debug.Log(i+=1);
    }
}

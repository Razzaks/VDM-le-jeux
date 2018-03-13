using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public Button option;
    public Button optionhide;
    public Button jouer;
    public Button quitter;


    // Use this for initialization
    public void Play (string PlayScene) {
        SceneManager.LoadScene(1);
	}

    public void Quitter(){
        Application.Quit();
    }

}

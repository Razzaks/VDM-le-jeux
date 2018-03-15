using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerDestroy : MonoBehaviour {
    public Runner player;
    public ScrollingLevel EndGame;
    public Animator Idle;
    public GameManager GameManager;


    // Use this for initialization
    void Start ()
    {
        GameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            EndGame.Stop = true;
            GameManager.NextGame();
        }
            

        if (other.gameObject.tag == "Fin")
        {
            player.Speed = 0;
            EndGame.Stop = true;
            Idle.SetTrigger("End");
            GameManager.NextGame();
        }
            
    }
}

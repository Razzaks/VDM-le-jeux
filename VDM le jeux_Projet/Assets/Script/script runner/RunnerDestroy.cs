using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerDestroy : MonoBehaviour {
    public Runner player;
    public ScrollingLevel EndGame;
    public Animator Idle;
    public TransitionScreen GameManager;


    // Use this for initialization
    void Start ()
    {
        GameManager = GameObject.Find("Transition Screen").GetComponent<TransitionScreen>();
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
            GameManager.EndGame();
        }
            

        if (other.gameObject.tag == "Fin")
        {
            player.Speed = 0;
            EndGame.Stop = true;
            Idle.SetTrigger("End");
            GameManager.EndGame();
        }
            
    }
}

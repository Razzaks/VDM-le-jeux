using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerDestroy : MonoBehaviour {
    public Runner player;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
            Destroy(gameObject);

        if (other.gameObject.tag == "Fin")
            player.Speed = 0;
    }
}

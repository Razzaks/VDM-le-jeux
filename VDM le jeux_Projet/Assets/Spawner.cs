using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject RunnerMan;

	// Use this for initialization
	void Start ()
    {
        RunnerMan = Instantiate(RunnerMan, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

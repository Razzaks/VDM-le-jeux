using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portablescript : MonoBehaviour {
    public Object portable;


    void Start () {
        transform.position = new Vector3(165, -20,-60);       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        transform.position = new Vector3(165, 20, -60);

        if (Input.GetKey("s"))
        transform.position = new Vector3(165, -20, -60);

    }

    }

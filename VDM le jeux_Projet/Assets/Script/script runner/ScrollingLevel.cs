using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingLevel : MonoBehaviour {

    public float Speed;
    public bool Stop;
    Vector3 StartPOS;

	// Use this for initialization
	void Start ()
    {
        StartPOS = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Stop == false)
        {
            transform.Translate((new Vector3(-1, 0, 0) * Speed * Time.deltaTime));
        }
	}
}

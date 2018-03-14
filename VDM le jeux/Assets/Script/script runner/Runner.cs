using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public float Speed;
    public float Jump;

    public Rigidbody2D Rbody;
    public Collider2D coll;

    bool grounded;
    public LayerMask Ground;


    // Use this for initialization
    void Start () {
        Rbody.GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.IsTouchingLayers(coll, Ground);

        Rbody.velocity = new Vector2(Speed, Rbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded){

                Rbody.velocity = new Vector2(Rbody.velocity.x, Jump);

            }
        }
    }
}

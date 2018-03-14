using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portablescript : MonoBehaviour {

    public GameObject portable;
    public bool Waiting = false;



    void Start()
    {
        //postion basse
        transform.position = new Vector3(165, -20, -60);
    }

    // Update is called once per frame
    void Update() {


       if (Input.GetButtonDown("R"))
        {
            //position haute
            transform.position = new Vector3(165, 20, -60);
            StartCoroutine(wait());
        }
        if (Input.GetButtonDown("E"))
        { 
            transform.position = new Vector3(165, 20, -60);
            StartCoroutine(wait());
        }

        if (Input.GetButtonDown("T"))
        {
            transform.position = new Vector3(165, 20, -60);
            StartCoroutine(wait());
        }
        else
        {
            if(Waiting == false)
            {
                transform.position = new Vector3(165, -20, -60);

            }
        }

    }

    IEnumerator wait()
    {
        Waiting = true;
        yield return new WaitForSeconds(3);
        Waiting = false;

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("vue");
    }

}

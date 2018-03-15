using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortableIMG : MonoBehaviour {

    public ImagePosition img;
    public bool Waiting = false;



    void Start()
    {
        //postion basse
        transform.position = new Vector3(155, -10, -96);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("R"))
        {
            //position haute
            transform.position = new Vector3(155, 0, -100);
            StartCoroutine(wait());
        }
        if (Input.GetButtonDown("E"))
        {
            transform.position = new Vector3(155, 0, -100);
            StartCoroutine(wait());
        }

        if (Input.GetButtonDown("T"))
        {
            transform.position = new Vector3(155, 0, -100);
            StartCoroutine(wait());
        }
        else
        {
            if (Waiting == false)
            {
                transform.position = new Vector3(155, -10, -96);

            }
        }

    }

    IEnumerator wait()
    {
        Waiting = true;
        yield return new WaitForSeconds(1);
        Waiting = false;

    }

}
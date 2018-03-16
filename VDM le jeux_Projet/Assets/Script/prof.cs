using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prof : MonoBehaviour
{
    private Animator animator;


    public float maxTime = 9f;
    public float minTime = 2f;

    private float time;
    private float waitTime;



    void Start()
    {
        waitTime = 0;
        animator = GetComponent<Animator>();
        SetRandomTime();
    }
    void SetRandomTime()
    {
       
        waitTime = Random.Range(minTime, maxTime);
     //   Debug.Log(waitTime);
    }

    void FixedUpdate()
    {

        time += Time.deltaTime;

        if (time >= waitTime)
        {
            // animation.Play(reverse);
            animator.SetTrigger("next");
            SetRandomTime();
            waitTime += time;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float time = 10f;
    public GameManager GameManager;
    bool CountDownOn;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(timer());
        time += 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    IEnumerator timer()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1f);
            time--;
            GetComponent<Text>().text = time.ToString();

        }
        if(time == 0)
        {
            GameManager.NextGame();
        }
    }
}

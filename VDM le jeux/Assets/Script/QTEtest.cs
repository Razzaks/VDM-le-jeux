using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTEtest : MonoBehaviour {

    public GameObject DisplayBox;
    public GameObject PassBox;

    public int QTEGen; // générateur de touches
    public int CorrectKey;
    public int CountingDone;

    void Update () {

        QTEGen = Random.Range(1, 4); // tableau possédant 4 rangés


    }
}

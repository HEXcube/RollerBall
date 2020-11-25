using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    Derived from https://learn.unity.com/tutorial/collecting-scoring-and-building-the-game
*/

public class PickupCollect : MonoBehaviour
{
    public Text scoreText;

    private int count;

    void Start ()
    {
        count = 0;
        SetScoreText ();
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pickup"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetScoreText ();
        }
    }

    void SetScoreText ()
    {
        scoreText.text = count.ToString ();
    }
}


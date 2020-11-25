using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Derived from https://learn.unity.com/tutorial/camera-and-play-area
*/

public class CameraFollowBall : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
    }
}


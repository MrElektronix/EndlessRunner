﻿using UnityEngine;
using System.Collections;

public class Camerafollow : MonoBehaviour {

    public Transform player;
    void Update()
    {
        transform.position = new Vector3(player.position.x + 3, 2, -10); 
    }
}
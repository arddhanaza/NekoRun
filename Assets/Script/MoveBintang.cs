﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBintang : MonoBehaviour {

    public float speed = 15;
    public float jalan = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if( Time.time > jalan)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        
        
    }
}

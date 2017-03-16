using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour {

    // Use this for initialization
    public float speed = 30;
    public float jalan = 10;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > jalan)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}

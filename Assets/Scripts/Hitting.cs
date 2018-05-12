﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour {

    public float speed = 10.0f;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Contact!");
        Destroy(this.gameObject);
    }
}
﻿using UnityEngine;
using System.Collections;

public class Destructor_laser : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D objeto) {
        if (objeto.tag == "destruir") {
            Destroy(gameObject);
        }
        if (objeto.tag == "enemigo"){
            Destroy(gameObject);
        }
    }
}

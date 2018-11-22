using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		   
	}




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            GameObject ball = collision.gameObject;

            ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}

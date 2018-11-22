using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potensia : MonoBehaviour {

    public int velocityx;
    public int velocityy;
    // Use this for initialization
    void Start () {
       gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocityx, velocityy));
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.anyKeyDown && gameObject.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocityx, velocityy));
        }
    }
}

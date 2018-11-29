using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour {

    public Sumidero sumidero;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            GameObject ball = collision.gameObject;

            ball.GetComponent<Potensia>().stop();


            sumidero.parada(ball);
        }
    }
}

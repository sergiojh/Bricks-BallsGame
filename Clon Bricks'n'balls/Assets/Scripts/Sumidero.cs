using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumidero : MonoBehaviour {
    int numBalls = 0;
    public SpawnBalls spawner;
	// Use this for initialization
	
    public void empezarmos()
    {
        numBalls = 0;
    }

    public void parada(GameObject pelota)
    {
        if(numBalls == 0)
        {
            gameObject.transform.position = pelota.transform.position;

            //petar bola
            Destroy(pelota);
            
        }

        else
        {
            pelota.transform.position = gameObject.transform.position;
            Destroy(pelota);
        }


        numBalls ++;


        if(numBalls >= 50)
        {
            spawner.moveTo(gameObject);
            spawner.RondaNueva(false);
        }
    }

}

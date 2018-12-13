using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumidero : MonoBehaviour {
    int numBalls = 0;
    int cont = 0;
    public SpawnBalls spawner;
    public SpriteRenderer activoRender;
    // Use this for initialization
    public void Start()
    {
        activoRender.enabled = true;
    }
    public void empezarmos()
    {
        //actualizar texto
        numBalls = 0;
        cont = 0;
    }

    public void Show()
    {
        activoRender.enabled = !activoRender.enabled;
    }

    public bool isShown()
    {
        return activoRender.enabled;
    }

    private void Arrived(Potensia ball)
    {
        Destroy(ball.gameObject);
        cont++;
        //actualizar texto
    }

    public void parada(Potensia pelota)
    {
        if(numBalls == 0)
        {
            activoRender.enabled = true;
            gameObject.transform.position = pelota.transform.position;
            gameObject.transform.Translate(new Vector3(0.0f,0.2f,0.0f));
            //petar bola
            Destroy(pelota.gameObject);
        }

        else
        {
            pelota.MoveTo(gameObject.transform.position,1.0f,Arrived);
        }


        numBalls ++;


        if(numBalls >= 50)
        {
            spawner.moveTo(gameObject);
            spawner.RondaNueva(false);
        }
    }

}

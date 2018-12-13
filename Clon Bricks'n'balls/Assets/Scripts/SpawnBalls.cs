using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour {

    public Potensia ball;
    public Sumidero sumidero;
    public int numBalls;
    public SpriteRenderer spriteBall;
    float velox, veloy;
    bool done = false;
    IEnumerator StartSpawning()
    {
        for (int i  = 0; i < numBalls; i++)
        {
            GameObject x =Instantiate(ball.gameObject,new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z),gameObject.transform.rotation);
            x.GetComponent<Potensia>().impulso(velox, veloy);
            yield return new WaitForSeconds(0.04f);
        }
        spriteBall.enabled = false;
    }

    public void RondaNueva(bool a)
    {
        done = a;
        spriteBall.enabled = true;
    }
    public bool getDone()
    {
        return done;
    }

    public void setVel(float velx, float vely)
    {
        velox = velx;
        veloy = vely;
    }

    public void Spawner()
    {
        
        sumidero.empezarmos();
        done = true;
        sumidero.Show();
        StartCoroutine("StartSpawning");
    }

    public void moveTo(GameObject x)
    {
        gameObject.transform.position = x.transform.position;
    }


}

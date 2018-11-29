using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potensia : MonoBehaviour {
    
    public void stop()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }

    public void impulso(float velx, float vely)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velx, vely));
    }

    public void moveTo(float x, float y)
    {
        gameObject.transform.position.Set(x, y, 0);
    }

}

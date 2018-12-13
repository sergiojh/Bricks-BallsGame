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
    public void MoveTo(Vector3 pos, float time, System.Action<Potensia> endMoveCallback = null)
    {
        StartCoroutine(MoveToCoroutine(pos, time, endMoveCallback));
    }


    private IEnumerator MoveToCoroutine(Vector3 pos, float time, System.Action<Potensia> endMoveCallback = null)
    {
        float totalTicks = time / Time.fixedDeltaTime;
        float distancePerTick = (pos - transform.position).magnitude / totalTicks;
        Vector2 dir = (pos - transform.position).normalized;
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        //Movimiento hasta la posición
        for (int i = 0; i < totalTicks; i++)
        {
            rb.position += dir * distancePerTick;
            yield return new WaitForFixedUpdate();
        }

        //Llama al callback
        if (endMoveCallback != null)
            endMoveCallback(this);

        yield return null;
    }


}

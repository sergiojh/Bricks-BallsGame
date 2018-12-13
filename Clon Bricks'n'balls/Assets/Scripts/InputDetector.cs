using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetector : MonoBehaviour {

    public SpawnBalls spawner;

	void Update () {
        //  MOVERLO
#if UNITY_ANDROID && !UNITY_EDITOR
        if (Input.touchCount > 0 && !spawner.GetComponent<SpawnBalls>().getDone()){

            Touch touch = Input.GetTouch(0);

            Vector3 v = touch.position;

#else
        if ((Input.GetMouseButtonUp(0) && !spawner.getDone()))

        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 v = ray.GetPoint(1);
            //ray.
            Vector3 a = new Vector3(v.x-spawner.transform.position.x,v.y - spawner.transform.position.y,0);

            a.Normalize();
            
            a *= 15;

            spawner.GetComponent<SpawnBalls>().setVel(a.x,a.y);

            spawner.GetComponent<SpawnBalls>().Spawner();
            

        }
#endif

    }
}

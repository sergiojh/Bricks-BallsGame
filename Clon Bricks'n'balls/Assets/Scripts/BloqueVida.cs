using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueVida : MonoBehaviour {

    public int vida;
    TextMesh textHijo;
	// Use this for initialization
	void Start () {
        textHijo = gameObject.GetComponentInChildren<TextMesh>();
        textHijo.text = vida.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            vida--;
            textHijo.text = vida.ToString();
            if (vida <= 0)
                Destroy(gameObject);
        }
    }

}

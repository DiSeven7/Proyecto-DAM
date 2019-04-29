using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdido : MonoBehaviour
{

    public Vector2 posInit;
    public GameObject bola;
    public GameObject desplazamiento;
    private Rigidbody2D rbb;
    public Desplazamiento desp;

    void Start()
    {
        //Cojo la posición de la bola
        rbb = bola.GetComponent<Rigidbody2D>();
        posInit = bola.transform.position;
    }

    void OnTriggerEnter2D(Collider2D suelo)
    {
        if (suelo.tag == "bola")
        {
            //Si la pelota toca el suelo, vuelve a la posición inicial y se para
            bola.transform.position = new Vector3(desplazamiento.transform.position.x,desplazamiento.transform.position.y+0.6f,desplazamiento.transform.position.z);
            bola.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rbb.isKinematic = true;
            desp.bolaParada = true;
        }
    }

}

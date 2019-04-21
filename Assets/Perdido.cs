using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdido : MonoBehaviour
{

    public Vector2 posInit;
    public GameObject bola;

    void Start()
    {
        //Cojo la posición de la bola
        posInit = bola.transform.position;
    }

    void OnTriggerEnter2D(Collider2D suelo)
    {
        if (suelo.tag == "bola")
        {
            //Si la pelota toca el suelo, vuelve a la posición inicial y se para
            bola.transform.position = posInit;
            bola.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

}

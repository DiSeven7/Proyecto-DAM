using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour
{

    public int velocidad;
    public int velocidad2;
    public float velocidadBola;
    public Rigidbody rbb;
    public GameObject desplazamiento;
    public GameObject bola;
    public static Rigidbody2D rb2d;
    public static Rigidbody2D rbb2d;
    public bool bolaParada = true;
 
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rbb2d = bola.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.Space)||Input.touchCount==1)&& bolaParada)
        {
            TiraBola();
        }
        else if ((Input.GetKey(KeyCode.Escape)))
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Input.GetAxis("X");
        Vector2 v2 = new Vector2(posX, 0);
        //Doy fuerza y velocidad a la pala
        rb2d.AddForce(v2 * velocidad2);
        rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -velocidad, velocidad), 0);
        rb2d.inertia = 0;
        //Evito que la pala se salga de la pantalla
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -15,15), transform.position.y);
    }

    void TiraBola()
    {
        if (Perdido.cuentamuertes != 4)
        {
            rbb2d.isKinematic = false;
            rb2d.isKinematic = false;
            rbb2d.AddForce(new Vector2(1, velocidadBola+velocidadBola/4));
            bolaParada = false;
        }
    }

}

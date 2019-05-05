using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour
{

    public int velocidad = 12;
    public int velocidad2 = 2000;
    public float velocidadBola = 10;
    public Rigidbody rbb;
    public GameObject desplazamiento;
    public GameObject bola;
    public static Rigidbody2D rb2d;
    private Rigidbody2D rbb2d;
    public bool bolaParada = true;

    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rbb2d= bola.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&&bolaParada)
        {
            TiraBola();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Input.GetAxis("X");
        Vector2 v2 = new Vector2(posX, 0);
        //Doy fuerza y velocidad a la pala
        rb2d.AddForce(v2 * velocidad);
        rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -velocidad, velocidad), 0);
        //Evito que la pala se salga de la pantalla
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -10, 10), transform.position.y);
    }

    void TiraBola() {
        rbb2d.isKinematic = false;
        rbb2d.AddForce(new Vector2(1, velocidadBola));
        bolaParada = false;
    }

}

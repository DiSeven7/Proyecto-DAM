using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour
{

    public int velocidad = 12;
    public int velocidad2 = 2000;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Input.GetAxis("X");
        Vector2 v2 = new Vector2(posX, 0);
        //Doy fuerza y velocidad a la pala
        rb2d.AddForce(v2 * velocidad);
        rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -velocidad, velocidad), 0);
        //Evito que la pala se salga de la pantalla
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -10, 10), transform.position.y);

    }
}

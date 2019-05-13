using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public Material material;
    public int puntos;
    public bool rompe = true;
    public int golpesAguante = 1;
    public int golpesSufridos = 0;
    public static int contadorPuntos = 0;
    public static int totalBloques = GeneradorBloques.totalfilas * GeneradorBloques.totalBloquesPorFila;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bola")
        {
            Colision();
        }
    }

    void Colision()
    {
        golpesSufridos += 1;
        if (golpesSufridos == golpesAguante)
        {
            totalBloques--;
            contadorPuntos += puntos;
            EliminarBloque();
        }
    }

    void EliminarBloque()
    {
        Destroy(gameObject);
    }

    public void AsignaColor(Material color, Material[] Colores)
    {
        GetComponent<MeshRenderer>().material = color;
        material = color;
        for (int i = 0; i < Colores.Length; i++)
        {
            if (material == Colores[i])
            {
                if (i == 0)
                {
                    puntos = 10;
                }
                else
                {
                    puntos = i * 10;
                }
                if (i == 0)
                {
                    golpesAguante = 1;
                }
                else
                {
                    golpesAguante = i;
                }
            }
        }
    }

}

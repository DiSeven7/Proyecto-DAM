using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBloques : MonoBehaviour
{

    public GameObject Bloque;
    public Material[] Colores;

    // Start is called before the first frame update
    void Start()
    {
        GeneraTotalFilas(8);
    }

    void GeneraFila(float altura)
    {
        for(int i = 0; i < 11; i++)
        {
            GameObject bloque = Instantiate(Bloque, new Vector2(i-(11-i), altura), Quaternion.identity);
            bloque.GetComponent<Bloque>().AsignaColor(Colores[Random.Range(0, Colores.Length)],Colores);
        }
    }

    void GeneraTotalFilas(int total)
    {
        for(float i = 0; i < total; i++)
        {
            GeneraFila(1+(i/2));
        }
    }

}

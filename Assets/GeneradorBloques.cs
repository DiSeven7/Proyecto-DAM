using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBloques : MonoBehaviour
{

    public GameObject Bloque;
    public Material[] Colores;
    public static int totalfilas = 7;
    public static int totalBloquesPorFila = 10;

    // Start is called before the first frame update
    void Start()
    {
        //if else estúpido pero necesario para evitar duplicidades al perder
        if (PonPuntos.restablece)
        {
            GeneraTotalFilas(totalfilas);
        }
        else
        {
            GeneraTotalFilas(totalfilas);
        }
    }

    void GeneraFila(float altura)
    {
        for(int i = 0; i < totalBloquesPorFila; i++)
        {
            GameObject bloque = Instantiate(Bloque, new Vector2(i - (totalBloquesPorFila - i), altura), Quaternion.identity);
            bloque.GetComponent<Bloque>().AsignaColor(Colores[Random.Range(0, Colores.Length)],Colores);
        }
    }

    void GeneraTotalFilas(int total)
    {
        for(float i = 0; i < total; i++)
        {
            GeneraFila((float)1.5+(i/2));
        }
    }
   
}

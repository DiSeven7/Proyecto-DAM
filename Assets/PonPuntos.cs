using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonPuntos : MonoBehaviour
{
    public TextMesh texto;

    void Start()
    {
        texto = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Perdido.cuentamuertes == 4)
        {
            texto.text = "Has perdido :(";
        }
        else if (Bloque.totalBloques==0)
        {
            texto.text = "¡Has ganado!";
        }
        else
        {
            texto.text = Bloque.contadorPuntos.ToString();
        }
    }
}

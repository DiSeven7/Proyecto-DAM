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
        texto.text = Bloque.contadorPuntos.ToString();
    }
}

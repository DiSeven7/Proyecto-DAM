using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PonPuntos : MonoBehaviour
{
    public TextMesh texto;
    public static bool restablece = false;

    void Start()
    {
        texto = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Perdido.cuentamuertes == 4)
        {
            actualizaPuntos();
            texto.text = "Has perdido :(";
            restablece = true;
            restableceJuego();
        }
        else if (Bloque.totalBloques == 0)
        {
            actualizaPuntos();
            texto.text = "¡Has ganado!";
            restablece = true;
            restableceJuego();
        }
        else
        {
            texto.text = Bloque.contadorPuntos.ToString();
        }
    }

    void restableceJuego()
    {
        if (Input.GetKey(KeyCode.Space) || Input.touchCount == 1)
        {
            SceneManager.LoadScene(0);
            Perdido.cuentamuertes = 0;
            Bloque.contadorPuntos = 0;
            Bloque.totalBloques = GeneradorBloques.totalfilas * GeneradorBloques.totalBloquesPorFila;
        }
    }

    void actualizaPuntos()
    {
        if (!File.Exists(Application.persistentDataPath + "/RecordPuntos.log"))
        {
            FileStream stream = File.Create(Application.persistentDataPath);
            using (StreamWriter sw = new StreamWriter(Application.persistentDataPath + "/RecordPuntos.log", false))
            {
                sw.Write("0");
            }
        }
        int puntos;
        puntos = int.Parse(File.ReadAllText(Application.persistentDataPath + "/RecordPuntos.log").ToString());
        int conseguidos = int.Parse(Bloque.contadorPuntos.ToString());
        if (conseguidos > puntos)
        {
            using (StreamWriter sw = new StreamWriter(Application.persistentDataPath + "/RecordPuntos.log", false))
            {
                sw.Write(conseguidos.ToString());
            }
        }
    }
}

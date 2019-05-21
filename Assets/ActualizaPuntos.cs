using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActualizaPuntos : MonoBehaviour
{

    public TextMesh texto;

    void Start()
    {
        TextoRecords();
    }

    public void TextoRecords()
    {
        string record = File.ReadAllLines(Application.persistentDataPath + "/RecordPuntos.log").ToString();
        texto = GetComponent<TextMesh>();
        texto.text = record;
    }

}

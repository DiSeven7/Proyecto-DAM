using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEscenas : MonoBehaviour
{
    public void Loader(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}

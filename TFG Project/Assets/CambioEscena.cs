using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public string nombre = "Escena2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el personaje ha cruzado el límite
        if (other.CompareTag("player"))
        {
            // Cambiar a la siguiente escena
            SceneManager.LoadScene(nombre);
        }
    }
}


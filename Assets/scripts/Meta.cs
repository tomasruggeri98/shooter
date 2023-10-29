using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto con el que el jugador colisionó tiene la etiqueta "Meta"
        if (other.CompareTag("Meta"))
        {
            // Recargamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;


    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si la colisión es con un objeto que tenga la etiqueta "enemigo"
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Destruir el objeto enemigo
            Destroy(collision.gameObject);
        }
    }
}

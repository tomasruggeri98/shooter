using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosEnemigo : MonoBehaviour
{

    [SerializeField] private int CantidadPuntos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            ControladorPuntos.instance.SumarPuntos(CantidadPuntos);
            Destroy(gameObject);
        }

    }

}

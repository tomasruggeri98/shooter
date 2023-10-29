using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform; // Reemplaza "Player" con el nombre del GameObject de tu jugador.
    }

    void Update()
    {
        // Calcula la dirección hacia el jugador.
        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        // Mueve la esfera hacia el jugador.
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

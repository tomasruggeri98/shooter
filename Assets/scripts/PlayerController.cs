using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Velocidad de movimiento del jugador.
    public float jumpHeight = 10.0f; // Altura del salto del jugador.
    private CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Obtener la entrada del jugador para el movimiento horizontal.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento en función de la entrada del jugador y la rotación de la cámara si es necesario.
        Vector3 move = transform.forward * verticalInput + transform.right * horizontalInput;

        // Aplicar la velocidad de movimiento al jugador.
        controller.Move(move * moveSpeed * Time.deltaTime);


        // Aplicar gravedad al jugador.
        moveDirection.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Reiniciar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

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

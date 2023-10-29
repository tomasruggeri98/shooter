using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player; // El transform del jugador.
    public float sensitivity = 2.0f; // Sensibilidad del ratón.
    public Vector2 pitchMinMax = new Vector2(-45, 45); // Rango de inclinación de la cámara.

    private float rotationX = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el cursor al centro de la pantalla.
        Cursor.visible = false; // Ocultar el cursor.
    }

    void Update()
    {
        // Obtener la entrada del ratón para la rotación de la cámara.
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotar el jugador horizontalmente según la entrada del ratón.
        player.Rotate(Vector3.up * mouseX);

        // Rotar la cámara verticalmente según la entrada del ratón, con restricciones de inclinación.
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, pitchMinMax.x, pitchMinMax.y);

        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}

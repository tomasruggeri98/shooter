using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player; // El transform del jugador.
    public float sensitivity = 2.0f; // Sensibilidad del rat�n.
    public Vector2 pitchMinMax = new Vector2(-45, 45); // Rango de inclinaci�n de la c�mara.

    private float rotationX = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el cursor al centro de la pantalla.
        Cursor.visible = false; // Ocultar el cursor.
    }

    void Update()
    {
        // Obtener la entrada del rat�n para la rotaci�n de la c�mara.
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotar el jugador horizontalmente seg�n la entrada del rat�n.
        player.Rotate(Vector3.up * mouseX);

        // Rotar la c�mara verticalmente seg�n la entrada del rat�n, con restricciones de inclinaci�n.
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, pitchMinMax.x, pitchMinMax.y);

        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}

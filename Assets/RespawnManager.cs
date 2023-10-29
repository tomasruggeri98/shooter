using System.Collections;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; // El prefab del enemigo que deseas respawnear.
    public Transform respawnPoint; // Punto donde aparecer�n los enemigos.

    private float respawnInterval = 3f; // Intervalo de respawn en segundos.

    private void Start()
    {
        // Comienza la corutina de respawn.
        StartCoroutine(RespawnEnemies());
    }

    IEnumerator RespawnEnemies()
    {
        while (true) // Esto har� que se repita constantemente.
        {
            // Crea un nuevo enemigo en el punto de respawn.
            Instantiate(enemyPrefab, respawnPoint.position, respawnPoint.rotation);

            // Espera el tiempo especificado antes de crear otro enemigo.
            yield return new WaitForSeconds(respawnInterval);
        }
    }
}

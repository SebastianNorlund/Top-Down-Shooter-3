using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Transform playerSpawnerLocation;
    public GameObject gameOverScreen;

    private HealthScript healthScript;
    private bool isDead = false;

    void Start()
    {
        healthScript = GetComponent<HealthScript>();   // works because both scripts are on Player
        transform.position = playerSpawnerLocation.position;
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        if (!isDead && healthScript.health <= 0)
        {
            isDead = true;
            gameOverScreen.SetActive(true); //enables the game over screen
            Time.timeScale = 0f; // pauses the game
        }
    }


    public void Respawn()
    {
        transform.position = playerSpawnerLocation.position;
        healthScript.health = 100;
        gameOverScreen.SetActive(false);
        Time.timeScale = 1f;
        isDead = false;
    
    
    
    
    
    
    }



}





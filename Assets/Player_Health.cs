using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.OnHealthZero += HandleGameOver;
    }

    // Method to take damage
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Ensure health doesn't go below 0
        healthBar.SetHealth(currentHealth);
    }


    void HandleGameOver()
    {
        Debug.Log("Game Over triggered");
        var gameOverScriptInstance = FindObjectOfType<gameOverScript>();
        if (gameOverScriptInstance != null)
        {
            gameOverScriptInstance.TriggerGameOver();
        }
        else
        {
            Debug.LogError("gameOverScript instance not found");
        }
    }

    private void OnDestroy()
    {
        healthBar.OnHealthZero -= HandleGameOver;
    }
    // Method to detect collisions with the "Shooter"
    //void OnCollisionEnter(Collision collision)
    //{
    //  if (collision.gameObject.name == "Shooter")
    //{
    //  TakeDamage(20);
    //}
    //}

    // Alternatively, if using triggers
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Shooter")
        {
            TakeDamage(20);
        }
    }
}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Health : MonoBehaviour // This script controls health of our enemy
{
    public float currentHealth = 10f; // Declaring the current health variable

    // Creating a new bullet object to access the bullet damage variable
    private PlayerScript player;
    public float powerupTimer = 0f;
    public float powerupDuration = 0f;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();

        powerupTimer = 60f;
        powerupDuration = 30f;
    }

    void Update()
    {
        if(transform.position.x < -9.5)
        {
            transform.position = new Vector3(-transform.position.x,transform.position.y,transform.position.z);
            player.player_currentHealth -= 1;
            player.UpdateHP();
        }

        powerupTimer -= Time.deltaTime;
        if (powerupTimer < 0)
        {
            powerupTimer = powerupDuration;
            currentHealth += 10f;
            Debug.Log("Enemy Health Increased to: " + currentHealth);
        }
    }
    
    public void TakeDamage() { // Declaring a function for other objects to "deal damage" to this object
         // Getting the player script component off the player game object and storing it in a variable
        currentHealth -= player.getDamage(); // Decreasing the current health of the object
        if (currentHealth <= 0)
        { // Checking if the current health is below or equal to 0
            Destroy(gameObject); // Destroy this gameobject
            player.Score += 5; // Increase the player's score by 1
            player.UpdateScore(); // Update the score text
        }
    }
}

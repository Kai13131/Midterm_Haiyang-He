using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Health : MonoBehaviour // This script controls health of our enemy
{
    public int currentHealth = 10; // Declaring the current health variable

    // Creating a new bullet object to access the bullet damage variable
    private PlayerScript player;
    
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
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

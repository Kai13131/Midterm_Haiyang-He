using UnityEngine;

public class Health : MonoBehaviour // This script controls health of our enemy
{
    public int currentHealth = 10; // Declaring the current health variable

    public void TakeDamage() { // Declaring a function for other objects to "deal damage" to this object
        currentHealth -= 1; // Decreasing the current health of the object
        if (currentHealth <= 0) { // Checking if the current health is below or equal to 0
            Destroy(gameObject); // Destroy this gameobject
        }
    }
}

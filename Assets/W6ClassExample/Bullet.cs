using UnityEngine;

public class Bullet : MonoBehaviour // This script controls the bullet movement and collision
{
    public Vector3 direction = new Vector3(1, 0, 0); // Declaring a variable for the direction the bullet is moving in
    public float speed = 0.1f; // Declaring a variable 

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed; // Moving bullet
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject otherGameObject = collision.gameObject; // Getting the object
        if(otherGameObject.CompareTag("Enemy")) { // Checking if the object you collided with is an enemy
            Health health = otherGameObject.GetComponent<Health>(); // Getting the health component off the enemy game object and storing it in a variable
            health.TakeDamage(); // Deal damage to the enemy health script
            Destroy(gameObject); // Now after colliding with enemy and dealing damage destroy the bullet
        }
    }
}

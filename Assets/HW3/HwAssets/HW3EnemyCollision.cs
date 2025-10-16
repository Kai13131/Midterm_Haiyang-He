using UnityEngine;

public class HW3EnemyCollision : MonoBehaviour
{
    // Collision checking
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player") { // Checking if the enemy is colliding with the player
            Destroy(collision.gameObject); // destroying the player if its the player
        }
    }

    
    private void Update()
    {
            
    }
}

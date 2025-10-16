using UnityEngine;

public class HW3SwordCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Enemy") { // Checking if colliding with enemy
            Destroy(collision.gameObject); // Destorying enemy if its an enemy
        }
    }
}

using UnityEngine;

public class DoodleJumpPlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public float force = 100f;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, force);
        }
    }
    private void Update() {
        Vector2 movementForce = new Vector2(0, 0); // Declaring the variable

        if (Input.GetKey(KeyCode.A)) { // Checking A input
            movementForce = new Vector2(-1, 0) * force; // Calculating the force added to move left
            rb.AddForce(movementForce); // Setting velocity
        }
        if (Input.GetKey(KeyCode.D)) { // Checking D input
            movementForce = new Vector2(1, 0) * force; // Calculating the force added to move right
            rb.AddForce(movementForce); // Setting velocity
        }
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 0.1f;
    void Update() {
        if (Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(1, 0, 0) * speed;
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position += new Vector3(-1, 0, 0) * speed;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(0, -1, 0) * speed;
        }
        if (Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(0, 1, 0) * speed;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float horizontalSpeed = speed * horizontalInput;
        float verticalSpeed = speed * verticalInput;

        Vector3 addPosition = new Vector3(horizontalSpeed, verticalSpeed, 0);
        transform.position += addPosition;
    }
}

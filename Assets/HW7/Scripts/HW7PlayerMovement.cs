using UnityEngine;

public class HW7PlayerMovement : MonoBehaviour
{
    public float speed = 10;

    Vector2 playerPosition;
    // Update is called once per frame
    void Update()
    {
        Vector3 inputDir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += inputDir * speed * Time.deltaTime;
    }
        

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            Destroy(gameObject);
        }
    }
    
}

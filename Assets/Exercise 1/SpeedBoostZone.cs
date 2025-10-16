using UnityEngine;

public class SpeedBoostZone : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 10f;

    public float side = 0;
    bool reachSide = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpeedBoostZone"))
        {
            force = force * 2;
            Debug.Log("Force is: " + force);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 movementForce = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            movementForce += new Vector2(1, 0) * force;
            rb.AddForce(movementForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementForce += new Vector2(-1, 0) * force;
            rb.AddForce(movementForce);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementForce += new Vector2(0, -1) * force;
            rb.AddForce(movementForce);
        }
        if (Input.GetKey(KeyCode.W))
        {
            movementForce += new Vector2(0, 1) * force;
            rb.AddForce(movementForce);
        }

        //////////////////////////////////////////////////////////
        Vector3 cameraSide = transform.position;

        if (cameraSide.x >= 16)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(-cameraSide.x, cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else if (cameraSide.x <= -16)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(-cameraSide.x, cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else if (cameraSide.y >= 9)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(cameraSide.x, -cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else if (cameraSide.y <= -9)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(cameraSide.x, -cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else
        {
            transform.position = transform.position;
        }
    }
}

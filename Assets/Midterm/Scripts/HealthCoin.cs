using UnityEngine;

public class HealthCoinMovement : MonoBehaviour
{
    public float speed = 1f;
    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);

        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}

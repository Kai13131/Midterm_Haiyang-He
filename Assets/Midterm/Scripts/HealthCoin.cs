using UnityEngine;

public class HealthCoin : MonoBehaviour
{
    public float speed = 0.01f;
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
        transform.Rotate(0, 0, 0.25f);

        transform.position += new Vector3(-speed, 0, 0);
    }
}

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerObject;
    public Vector3 playerLocation = new Vector3(0, 0, 0);
    public float speed = 0.05f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerLocation = playerObject.transform.position;
        Vector3 vectorToTarget = playerLocation - transform.position;
        Vector3 dirctionToTarget = vectorToTarget.normalized;
        Vector3 velocity = dirctionToTarget * speed;
        transform.position += velocity;
    }
}

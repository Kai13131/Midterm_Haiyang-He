using UnityEngine;

public class PivotRoation : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = 1;
        transform.Rotate(0, 0, speed * velocity);

    }
}

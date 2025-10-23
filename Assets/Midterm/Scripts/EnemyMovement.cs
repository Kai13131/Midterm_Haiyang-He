using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        //Rotating the enemy around the Z axis
        transform.Rotate(0,0, 1f);

        transform.position += new Vector3(-0.001f, 0, 0);

        
    }
}

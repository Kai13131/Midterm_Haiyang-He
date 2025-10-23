using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.01f;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Rotating the enemy around the Z axis
        transform.Rotate(0,0, 1f);
        
        transform.position += new Vector3(-speed, 0, 0);

        

    }
}

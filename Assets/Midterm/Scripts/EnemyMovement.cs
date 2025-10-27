using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    private Health enemyHealth;
    

    void Start()
    {
        
        enemyHealth = GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotating the enemy around the Z axis
        transform.Rotate(0,0, moveSpeed);

        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;

        
    }

}

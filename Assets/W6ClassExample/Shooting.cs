using UnityEngine;

public class Shooting : MonoBehaviour // This script controls the player shooting bullets
{
    public GameObject bulletPrefab; // The prefab that you put here in the editor

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) { // Checking if the player pressed space
            Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 0)); // Spawning the bullet prefab on the current game object
        }
    }
}

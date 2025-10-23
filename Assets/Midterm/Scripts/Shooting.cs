using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour // This script controls the player shooting bullets
{
    public GameObject bulletPrefab;
    public float shootTime = 0.0f;
    public float shootCooldown = 0.5f;

    void Update()
    {
        shootTime -= Time.deltaTime;
        if(shootTime < 0) {
            shootTime = shootCooldown;
            Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        }
    }
}

using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
public class Spawn : MonoBehaviour
{
    public float enemyTimer = 0.0f;
    public float healthCoinTimer = 0.0f;
    public float damageCoinTimer = 0.0f;
    public float shootingSpeedTimer = 0.0f;

    float enemyDuration = 0f;
    float healthCoinDuration = 0f;
    float damageCoinDuration = 0f;
    float shootingSpeedDuration = 0f;

    public GameObject enemyPrefab;
    public GameObject healthCoinPrefab;
    public GameObject damageCoinPrefab;
    public GameObject shootingSpeedCoinPrefab;

    private Health enemyHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        enemyHealth = GetComponent<Health>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //Enemy Spawn
        enemyTimer -= Time.deltaTime;
        if (enemyTimer < 0)
        {
            enemyDuration = Random.Range(7f, 10f);
            enemyTimer = enemyDuration;
            enemySpawn();
        }
        //Health Coin Spawn
        healthCoinTimer -= Time.deltaTime;
        if (healthCoinTimer < 0)
        {
            healthCoinDuration = Random.Range(30f, 60f);

            healthCoinTimer = healthCoinDuration;
            healthCoinSpawn();
        }
        //Damage Coin Spawn
        damageCoinTimer -= Time.deltaTime;
        if (damageCoinTimer < 0)
        {
            damageCoinDuration = Random.Range(60f, 90f);

            damageCoinTimer = damageCoinDuration;
            damageCoinSpawn();
        }
        //Shooting Speed Coin Spawn
        shootingSpeedTimer -= Time.deltaTime;
        if (shootingSpeedTimer < 0)
        {
            shootingSpeedDuration = Random.Range(40f, 70f);

            shootingSpeedTimer = shootingSpeedDuration;
            shootingSpeedCoinSpawn();
        }
    }

    void enemySpawn()
    {
        Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
    }

    void healthCoinSpawn()
    {
        Instantiate(healthCoinPrefab, new Vector3(12, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
    }
    void damageCoinSpawn()
    {
        Instantiate(damageCoinPrefab, new Vector3(12, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
    }
    void shootingSpeedCoinSpawn()
    {
        Instantiate(shootingSpeedCoinPrefab, new Vector3(12, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
    }
}

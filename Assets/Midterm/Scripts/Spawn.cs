using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
public class Spawn : MonoBehaviour
{
    public float enemyTimer = 0.0f;
    public float healthCoinTimer = 0.0f;
    public float damageCoinTimer = 0.0f;
    public float shootingSpeedTimer = 0.0f;
    public float powerUpEnemyTimer = 0.0f;

    float enemyDuration = 0f;
    float healthCoinDuration = 0f;
    float damageCoinDuration = 0f;
    float shootingSpeedDuration = 0f;
    float powerUpenemyDuration = 0f;

    public GameObject enemyPrefab;
    public GameObject healthCoinPrefab;
    public GameObject damageCoinPrefab;
    public GameObject shootingSpeedCoinPrefab;

    GameObject newEnemy1;
    GameObject newEnemy2;
    GameObject newEnemy3;
    float enemyHealth = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        //Enemy Spawn
        enemyTimer -= Time.deltaTime;
        powerUpEnemyTimer -= Time.deltaTime;

        if (enemyTimer < 0)
        {
            enemyDuration = Random.Range(5f, 10f);
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
            damageCoinDuration = Random.Range(15f, 30f);

            damageCoinTimer = damageCoinDuration;
            damageCoinSpawn();
        }
        //Shooting Speed Coin Spawn
        shootingSpeedTimer -= Time.deltaTime;
        if (shootingSpeedTimer < 0)
        {
            shootingSpeedDuration = Random.Range(15f, 30f);

            shootingSpeedTimer = shootingSpeedDuration;
            shootingSpeedCoinSpawn();
        }
    }

    void enemySpawn()
    {
        newEnemy1 = Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        newEnemy2 = Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        newEnemy3 = Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));

        newEnemy1.GetComponent<Health>().currentHealth = enemyHealth;
        newEnemy2.GetComponent<Health>().currentHealth = enemyHealth;
        newEnemy3.GetComponent<Health>().currentHealth = enemyHealth;
        Debug.Log("Current Health: " + enemyHealth);
        if (powerUpEnemyTimer < 0 && powerUpEnemyTimer > -10)
        {
            powerUpenemyDuration = 45f;
            powerUpEnemyTimer = powerUpenemyDuration;

            enemyHealth *= 1.5f;
            Debug.Log("Next Round Enemy Health: " +  enemyHealth);
        }
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

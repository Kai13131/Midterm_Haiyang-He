using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
public class Spawn : MonoBehaviour
{
    public float enemyTimer = 0.0f;
    public float healthCoinTimer = 0.0f;
    public float damageCoinTimer = 0.0f;

    public float enemyDuration = 5;
    public float healthCoinDuration = 30;
    public float damageCoinDuration = 45;

    public float enemyPowerupTimer = 0.0f;
    public float enemyPowerupDuration = 60f;

    public GameObject enemyPrefab;
    public GameObject healthCoinPrefab;
    public GameObject damageCoinPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        

    }
    
    // Update is called once per frame
    void Update()
    {
        enemyTimer -= Time.deltaTime;
        if (enemyTimer < 0)
        {
            enemyTimer = enemyDuration;
            Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
            Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
            Instantiate(enemyPrefab, new Vector3(11, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        }

        healthCoinTimer -= Time.deltaTime;
        if (healthCoinTimer < 0)
        {
            healthCoinTimer = healthCoinDuration;
            Instantiate(healthCoinPrefab, new Vector3(12, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        }

        damageCoinTimer -= Time.deltaTime;
        if (damageCoinTimer < 0)
        {
            damageCoinTimer = damageCoinDuration;
            Instantiate(damageCoinPrefab, new Vector3(12, Random.Range(-4.5f, 4.5f), 0), Quaternion.Euler(0, 0, 0));
        }

        enemyPowerupTimer -= Time.deltaTime;
        if(enemyPowerupTimer < 0)
        {
            enemyPowerupTimer = enemyPowerupDuration;
            enemyPrefab.GetComponent<Health>().currentHealth += 10;
        }
    }
}

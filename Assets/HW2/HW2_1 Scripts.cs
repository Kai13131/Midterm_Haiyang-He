using UnityEngine;

public class HW2_1Scripts : MonoBehaviour
{
    float currentHealth = 0;
    float regenAmount = 15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth += regenAmount;
        Debug.Log("Healing: " + regenAmount + "% HP");
        Debug.Log("Current Health: " + currentHealth + "HP");
    }
}

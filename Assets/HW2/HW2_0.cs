using UnityEngine;

public class HW2_0 : MonoBehaviour
{
    int numberAlive = 10;
    string userName = "MyGuy";
    bool isAlive = true;
    float currentHealth = 0;

    void Start()
    {
        float x = 10;
        x /= 100;
        Debug.Log(x); // This should print 0.1

        float bonusMultiplier = 0.5f;
        float output = 10 * (bonusMultiplier + 1);
        Debug.Log(output); // This should print 15
    }

    void Update()
    {
        
    }
}

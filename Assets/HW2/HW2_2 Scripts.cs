using UnityEngine;

public class HW2_2Scripts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string firstName = "The";
        string lastName = "Kai";
        Debug.Log("You first name and last name are: " + firstName + " " + lastName);

        string fullName = firstName + " " + lastName;
        Debug.Log("You full name is: " + fullName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

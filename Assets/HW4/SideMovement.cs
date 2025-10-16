using UnityEngine;

public class SideMovement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public float side = 0;
    bool reachSide = false;
    // Update is called once per frame
    void Update()
    {
        Camera camera = Camera.main;
        side = camera.fieldOfView;

        Vector3 cameraSide = transform.position;

        if(cameraSide.x >= 10)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(-cameraSide.x, cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else if (cameraSide.x <= -10)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(-cameraSide.x, cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else if (cameraSide.y >= 6)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(cameraSide.x, -cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else if (cameraSide.y <= -6)
        {
            reachSide = true;
            if (reachSide)
            {
                transform.position = new Vector3(cameraSide.x, -cameraSide.y, cameraSide.z);
            }
            else
            {
                reachSide = false;
            }
        }
        else
        {
            transform.position = transform.position;
        }

            Debug.Log(transform.position.x);
    }
}

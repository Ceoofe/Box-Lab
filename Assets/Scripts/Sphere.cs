using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject spawnpos; // Where I want it to spawn
    public GameObject Ball; // Gets the Sphere itself
    private GameObject AnotherBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clone()
    {
        float instX = spawnpos.transform.position.x;
        float instY = spawnpos.transform.position.y;
        
        AnotherBall = Instantiate(Ball, new Vector3(instX, instY, 0), Quaternion.identity);// This creates a clone of the ball
    }
}

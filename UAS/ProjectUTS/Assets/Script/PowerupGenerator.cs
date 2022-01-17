using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject powerup;
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0.8f, 1.3f);
    }
    void CreateObstacle()
    {
        if (Random.Range(0, 10) >= 9)
        {
            Instantiate(powerup);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

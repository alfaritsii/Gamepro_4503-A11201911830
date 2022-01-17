using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocks;
    public GameObject ufo;
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0.8f, 1.3f);
    }
    void CreateObstacle()
    {
        if (ScoreManager.instance.GetScore() <= 10)
        {
            Instantiate(rocks);
        }
        else if (ScoreManager.instance.GetScore() >=11)
        {
            Instantiate(ufo);
        }
        ScoreManager.instance.AddScore(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

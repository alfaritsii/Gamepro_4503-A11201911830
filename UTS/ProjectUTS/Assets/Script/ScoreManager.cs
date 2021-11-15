using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public Text scoreText;
    int score = 0;

    private void Awake() {
        instance = this;
    }
    void Start()
    {
        scoreText.text ="Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int value){
        score += value;
        scoreText.text = "Score: " + score.ToString();
    }
    public int GetScore(){
       return score;
    }
}

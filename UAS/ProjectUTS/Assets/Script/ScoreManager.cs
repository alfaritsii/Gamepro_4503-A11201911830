using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public Text scoreText;
    public Text lifeText;
    public Text levelText;
    int score = 0;
    int life = 3;
    int level =1;

    private void Awake() {
        instance = this;
    }
    void Start()
    {
        scoreText.text ="Score: " + score.ToString();
        lifeText.text ="" + life.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int value){
        score += value;
        scoreText.text = "Score: " + score.ToString();
        if (score % 10 == 0)
        {
            level = level+1;
            levelText.text = "Level: " + level.ToString();
        }
        if (score == 10)
        {
            BackgroundScript.instance.changeBackground();
        }
    }
    public void AddLife(int value){
        life += value;
        lifeText.text ="" + life.ToString();
    }
    public void RemoveLife(int value){
        life -= value;
        lifeText.text ="" + life.ToString();
        if (life <= 0)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main"))
            {
                SceneManager.LoadScene("GameOver");
            }else{
                SceneManager.LoadScene("GameOver2");
            }
        }
    }
    public int GetScore(){
       return score;
    }
    public int GetLife(){
       return life;
    }
}

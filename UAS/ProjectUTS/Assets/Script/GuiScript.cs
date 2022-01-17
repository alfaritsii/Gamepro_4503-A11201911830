using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playgame(){
         SceneManager.LoadScene("PlayMenu");
    }
     public void on_play(){
        SceneManager.LoadScene("Main");
    }
    public void on_play2(){
        SceneManager.LoadScene("Main2");
    }

    public void back_menu(){
         SceneManager.LoadScene("Menu");
    }
    public void on_about(){
         SceneManager.LoadScene("About");
    }
    public void on_howto(){
         SceneManager.LoadScene("HowToPlay");
    }

}

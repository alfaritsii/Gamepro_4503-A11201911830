using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NabrakScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameObject collision;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        collision = GameObject.FindGameObjectWithTag("rock");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "pembatas")
       {
           Destroy(this.gameObject);
       }
       else if (collision.tag == "Player")
       {
           Destroy(player.gameObject);
           SceneManager.LoadScene("GameOver");
       }
    }
   
    
}
 

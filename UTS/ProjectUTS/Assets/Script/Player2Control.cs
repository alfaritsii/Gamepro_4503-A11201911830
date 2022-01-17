using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Control : MonoBehaviour
{
   // Start is called before the first frame update
    public Vector2 jumpforce = new Vector2(0,300);
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("up")){
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpforce);
        }
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
       if(player.tag == "pembatas")
       {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main"))
            {
                SceneManager.LoadScene("GameOver");
            }else{
                SceneManager.LoadScene("GameOver2");
            }
       }
    }
}

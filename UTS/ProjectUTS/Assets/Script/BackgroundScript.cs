using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static BackgroundScript instance;
    public GameObject background2;
    public GameObject background1;
     private void Awake() {
        instance = this;
    }
    void Start()
    {
        changeBackground();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeBackground()
    {
        if (background2.activeSelf)
        {
            background2.SetActive(false);
             background1.SetActive(true);
        }
        else
        {
            background2.SetActive(true);
            background1.SetActive(false);
        }
    }
}

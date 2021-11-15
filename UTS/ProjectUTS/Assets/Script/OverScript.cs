using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static OverScript instance;
    public Text scoreFinal;
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        scoreFinal.text ="Score: " + ScoreManager.instance.GetScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

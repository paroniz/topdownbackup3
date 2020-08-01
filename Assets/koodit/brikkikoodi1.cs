using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brikkikoodi1 : MonoBehaviour {
    
    public GameObject patsas;
    
    public bool tuhoa = false;
    //private bool onkoauki = false;
    
    void Start() {}



    void Update() 
    {
        //onkoauki = patsas.GetComponent<patsasaktvointikoodi1>();
        
        // if (patsas.GetComponent<patsasaktvointikoodi1>().auki == true)
        // {
        //     Debug.Log("yolo3");
        //     Destroy(gameObject);
        // }

        if(tuhoa)
        {
            Destroy(gameObject);
        }
    }
}

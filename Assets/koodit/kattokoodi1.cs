using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class kattokoodi1 : MonoBehaviour {
    

     //public Color uuskolori = Color.white; 
    private GameObject katto;
     //private Tilemap katto2;
    void Start() {
       katto = GameObject.Find("katto");  
    }

    void Update() {}

    private void OnTriggerEnter2D(Collider2D other)
    {
         if(other.tag == "hero")
        {
        Debug.Log("yolo");
        katto.transform.position = new Vector3(0, 0, -200);  
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
         if(other.tag == "hero")
        {
            Debug.Log("yolo2");
            katto.transform.position = new Vector3(0, 0,0);
        }
    }
}

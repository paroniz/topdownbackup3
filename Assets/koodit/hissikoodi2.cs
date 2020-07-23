using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class hissikoodi2 : MonoBehaviour {
    

     //public Color uuskolori = Color.white; 
    private GameObject hissi;
    private GameObject alusta;
    private GameObject kohde;
   
     //private Tilemap katto2;
    void Start() {
       hissi = GameObject.Find("loossi");  
       alusta = GameObject.Find("space");  
       
    }

    void Update() {
        kohde = GameObject.FindGameObjectWithTag("hero");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
         if(other.tag == "hero")
        {
        Debug.Log("yolo3");
        hissi.transform.position = new Vector3(0, 0, 0);  
        alusta.transform.position = new Vector3(0, 0, 0);  
        kohde.transform.position = new Vector3(-8.67f,49.78f,0f);
        
        }
        
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
         if(other.tag == "hero")
        {
            Debug.Log("yolo23");
            //hissi.transform.position = new Vector3(0, 0,0);
        }
    }
}
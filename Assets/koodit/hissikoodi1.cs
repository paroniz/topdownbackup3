using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class hissikoodi1 : MonoBehaviour {
    

     //public Color uuskolori = Color.white; 
    private GameObject hissi;
    private GameObject alusta;
    private GameObject spacearound;
    private GameObject kohde;
    private bool kytketty1;
    private bool kytketty2;
    private GameObject tietokone1;
    private GameObject tietokone2;
   
     //private Tilemap katto2;
    void Start() {
        hissi = GameObject.Find("loossi");  
        spacearound = GameObject.Find("spacearound");
        tietokone1 = GameObject.Find("tietokone1");
        tietokone2 = GameObject.Find("tietokone2");
       
    }

    void Update() {
        kohde = GameObject.FindGameObjectWithTag("hero");
        kytketty1 = tietokone1.GetComponent<tietokonekoodi1>().kytketty;
        kytketty2 = tietokone1.GetComponent<tietokonekoodi1>().kytketty;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
         if(other.tag == "hero" && kytketty1 && kytketty2)
        {
        Debug.Log("yolo");
        hissi.transform.position = new Vector3(0, 0, -200);  
        spacearound.transform.position = new Vector3(0, 0, -200);  
        kohde.transform.position = new Vector3(2.09f,74.45f,0f);
        
        }
        
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
         if(other.tag == "hero")
        {
            Debug.Log("yolo2");
            //hissi.transform.position = new Vector3(0, 0,0);
        }
    }
}

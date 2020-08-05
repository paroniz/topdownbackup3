using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktivointikoodi2 : MonoBehaviour {

    public Sprite mySprite;
    public bool auki2 = false;
    public Sprite defaultsprite;
    public bool voikoskea2 = true;
    private bool triggered = false;
    
    void Start() {}

    void Update() 
    {
        if(triggered && Input.GetButtonDown("Fire2") && voikoskea2 == true)
        {
            //Debug.Log("yoylo76");
            this.GetComponent<SpriteRenderer>().sprite = mySprite;
                
            if(GameObject.Find("irvistys1").GetComponent<patsasaktvointikoodi1>().auki1 == true)
            {
                auki2 = true;
                Debug.Log("oikea jarjestys");
            }
            else
            {
                Debug.Log("vaara jarjestys");
            }
            voikoskea2 = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "hero")
        {
            triggered = true;
        }
    }  
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "hero")
        {
            triggered = false;
        }
    }  
}
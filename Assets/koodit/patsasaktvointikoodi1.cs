using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktvointikoodi1 : MonoBehaviour {

    public bool auki1 = false;
    public Sprite mySprite;
    public bool voikoskea = true;
    private bool triggered = false;
     
    void Start() {}

    void Update() 
    {
        if(triggered && Input.GetButtonDown("Fire2") && voikoskea == true )
        {
            //Debug.Log("yoylo76");
            this.GetComponent<SpriteRenderer>().sprite = mySprite;
            auki1 = true;
            voikoskea = false;
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

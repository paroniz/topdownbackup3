﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktivointikoodi5 : MonoBehaviour {

    public Sprite mySprite;
    public bool auki5 = false;
    public Sprite defaultsprite;
    public bool voikoskea5 = true;
    private bool triggered = false;
 
    void Start() {}

    void Update() 
    {
        if(triggered && Input.GetButtonDown("Fire2") && voikoskea5 == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = mySprite;
            
            if(GameObject.Find("irvistys4").GetComponent<patsasaktivointikoodi4>().auki4 == true)
            {
                auki5 = true;
                Debug.Log("oikea jarjestys5");
            }
            else
            {
                Debug.Log("vaara jarjestys5");
            }
            voikoskea5 = false;
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpnlisayskoodi : MonoBehaviour {
    
    private bool triggered = false;
    private GameObject hero;
    public bool voikoskea = true;
    
    void Start() {}

    void Update() 
    {
        hero = GameObject.FindGameObjectWithTag("hero");

        if(triggered && Input.GetKeyDown(KeyCode.E) && voikoskea == true )
        {
            Debug.Log("yoyloscrolli");
            Healaa();
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

    void Healaa()
    {
        //Debug.Log("healaa");
        int lisahp = hero.GetComponent<herodelaus>().hp;
        lisahp ++;
        hero.GetComponent<herodelaus>().hp = lisahp;
        Destroy(gameObject);
    } 
}

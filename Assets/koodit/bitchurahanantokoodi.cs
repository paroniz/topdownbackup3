using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bitchurahanantokoodi : MonoBehaviour {
    
    public static int rahat;
    private string rahamaara ="moi";
    private int rahamaara2;
    private bool voikoskea = true;
    private bool triggered = false;
    private GameObject t1 = null;

    void Start() {
        t1 = GameObject.Find("rahat");
    }
    

void Update() 
    {
        if(triggered && Input.GetButtonDown("Fire2") && voikoskea == true )
        {
            rahamaara = t1.GetComponent<Text>().text;
            rahamaara2 = System.Convert.ToInt32(rahamaara);
            rahamaara2 += 500;
            rahamaara = rahamaara2.ToString();
            t1.GetComponent<Text>().text = rahamaara;
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

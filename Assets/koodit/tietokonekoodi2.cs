using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tietokonekoodi2 : MonoBehaviour {

    public bool auki1 = false;
    public Sprite mySprite;
    public bool voikoskea = true;
    private bool triggered = false;
    public GameObject tiet2;
    private GameObject tiet22;

    private GameObject tiet222;
    private GameObject tiet33;
    private GameObject tiet44;

    private SpriteRenderer tietorenderer;

 
    public bool kytketty = false;

    
     
    void Start() {
        tiet222 = GameObject.Find("tietokone22");
        tiet33 = GameObject.Find("tietokone33");
        tiet44 = GameObject.Find("tietokone44");
    }

    void Update() {

       

        if(triggered && Input.GetKeyDown(KeyCode.E) && voikoskea == true )
        {
            Debug.Log("yoylotietokone");
            this.GetComponent<SpriteRenderer>().sprite =mySprite;
            voikoskea = false;
            kytketty = true;
            tiet22 = Instantiate(tiet2, transform.position, transform.rotation);
            this.GetComponent<SpriteRenderer>().enabled = false;
            this.GetComponentInChildren<SpriteRenderer>().enabled = false;
            tiet222.GetComponent<SpriteRenderer>().enabled = false;
            tiet33.GetComponent<SpriteRenderer>().enabled = false;
            tiet44.GetComponent<SpriteRenderer>().enabled = false;
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
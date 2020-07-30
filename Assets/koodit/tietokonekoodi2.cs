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

    private SpriteRenderer tietorenderer;

 
    public bool kytketty;

    
     
    void Start() {
        
    }

    void Update() {

       

        if(triggered && Input.GetKeyDown(KeyCode.E) && voikoskea == true )
        {
            Debug.Log("yoylotietokone");
            this.GetComponent<SpriteRenderer>().sprite =mySprite;
            voikoskea = false;
        
            kytketty = true;
            tiet22 = Instantiate(tiet2, transform.position, transform.rotation);
            Destroy(gameObject);
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
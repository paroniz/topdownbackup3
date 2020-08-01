using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tietokonekoodi1 : MonoBehaviour {

    public bool auki1 = false;
    public Sprite mySprite;
    public bool voikoskea = true;
    private bool triggered = false;
    public GameObject ovi;
    private SpriteRenderer tietorenderer;
    public GameObject elektroovi;
    public GameObject rajahdysani;
    public bool kytketty;

    void Start() {}

    void Update() 
    {
        if(triggered && Input.GetKeyDown(KeyCode.E) && voikoskea == true)
        {
            Debug.Log("yoylotietokone");
            this.GetComponent<SpriteRenderer>().sprite =mySprite;
            Destroy(ovi);
            Destroy(elektroovi);
            voikoskea = false;
            GameObject rajahjdys = Instantiate(rajahdysani, new Vector2(-23.5f, 50f), transform.rotation);
            kytketty = true;
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
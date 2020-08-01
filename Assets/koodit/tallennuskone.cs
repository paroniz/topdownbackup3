using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tallennuskone : MonoBehaviour {

    public GameObject tiet2;
    private GameObject tiet22;
    public bool auki1 = false;
    public bool voikoskea = true;
    public bool kytketty;
    private bool triggered = false;
    private SpriteRenderer tietorenderer;

    void Start() {}

    void Update() 
    {
        if(triggered && Input.GetKeyDown(KeyCode.E) && voikoskea == true)
        {
            //Debug.Log("tietokone");
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
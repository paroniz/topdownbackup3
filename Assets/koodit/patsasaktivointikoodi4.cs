using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktivointikoodi4 : MonoBehaviour {

    public Sprite mySprite;
    public bool auki4 = false;
    public Sprite defaultsprite;
    public bool voikoskea4 = true;
    private bool triggered = false;
 
    void Start() {}

    void Update() 
    {
        if(triggered && Input.GetButtonDown("Fire2") && voikoskea4 == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = mySprite;

            if(GameObject.Find("irvistys3").GetComponent<patsasaktivointikoodi3>().auki3 == true)
            {
                auki4 = true;
                Debug.Log("oikea jarjestys4");
            }
            else
            {
                Debug.Log("vaara jarjestys4");
            }
            voikoskea4 = false;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktivointikoodi2 : MonoBehaviour {

    public Sprite mySprite;
    public bool auki2 = false;
    public Sprite defaultsprite;
    public bool voikoskea2 = true;
 
    void Start() {}

    void Update() {}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "hero" && Input.GetKeyDown(KeyCode.E)  && voikoskea2 == true)
        {
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
}

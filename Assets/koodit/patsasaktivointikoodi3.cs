using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktivointikoodi3 : MonoBehaviour {

    public Sprite mySprite;
    public bool auki3 = false;
    public Sprite defaultsprite;
    public bool voikoskea3 = true;
 
    void Start() {}

    void Update() {}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "hero" && Input.GetKeyDown(KeyCode.E)  && voikoskea3 == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = mySprite;
            if(GameObject.Find("irvistys2").GetComponent<patsasaktivointikoodi2>().auki2 == true)
            {
                auki3 = true;
                Debug.Log("oikea jarjestys");
            }
            else
            {
                Debug.Log("vaara jarjestys");
            }
            voikoskea3 = false;
        } 
    }
}

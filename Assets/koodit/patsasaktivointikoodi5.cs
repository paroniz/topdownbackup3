using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patsasaktivointikoodi5 : MonoBehaviour {

    public Sprite mySprite;
    public bool auki5 = false;
    public Sprite defaultsprite;
    public bool voikoskea5 = true;
 
    void Start() {}

    void Update() {}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "hero" && Input.GetKeyDown(KeyCode.E)  && voikoskea5 == true)
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
}

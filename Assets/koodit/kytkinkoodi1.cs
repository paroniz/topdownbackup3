using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kytkinkoodi1 : MonoBehaviour {

    public Sprite mySprite;
    public Sprite defaultsprite;
    private bool voikoskea = true;
    
    void Start() {}

    void Update() {}

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "hero" && Input.GetKeyDown(KeyCode.E) && voikoskea)
        {

            if(GameObject.Find("irvistys5").GetComponent<patsasaktivointikoodi5>().auki5 == true)
            {
                Debug.Log("oviauki");
                GameObject.Find("testiovi").GetComponent<brikkikoodi1>().tuhoa = true;
                this.GetComponent<SpriteRenderer>().sprite = mySprite;
                voikoskea = false;
            }

            else
            {
                Debug.Log("resetoitu");
                resetoi();
            }
        }
    }

    void resetoi()
    {
        GameObject.Find("irvistys1").GetComponent<SpriteRenderer>().sprite = defaultsprite;
        GameObject.Find("irvistys1").GetComponent<patsasaktvointikoodi1>().voikoskea = true;
        GameObject.Find("irvistys1").GetComponent<patsasaktvointikoodi1>().auki1 = false;
        GameObject.Find("irvistys2").GetComponent<SpriteRenderer>().sprite = defaultsprite;
        GameObject.Find("irvistys2").GetComponent<patsasaktivointikoodi2>().voikoskea2 = true;
        GameObject.Find("irvistys2").GetComponent<patsasaktivointikoodi2>().auki2 = false;
        GameObject.Find("irvistys3").GetComponent<SpriteRenderer>().sprite = defaultsprite;
        GameObject.Find("irvistys3").GetComponent<patsasaktivointikoodi3>().voikoskea3 = true;
        GameObject.Find("irvistys3").GetComponent<patsasaktivointikoodi3>().auki3 = false;
        GameObject.Find("irvistys4").GetComponent<SpriteRenderer>().sprite = defaultsprite;
        GameObject.Find("irvistys4").GetComponent<patsasaktivointikoodi4>().voikoskea4 = true;
        GameObject.Find("irvistys4").GetComponent<patsasaktivointikoodi4>().auki4 = false;
        GameObject.Find("irvistys5").GetComponent<SpriteRenderer>().sprite = defaultsprite;
        GameObject.Find("irvistys5").GetComponent<patsasaktivointikoodi5>().voikoskea5 = true;
        GameObject.Find("irvistys5").GetComponent<patsasaktivointikoodi5>().auki5 = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aseenvaihtokoodi : MonoBehaviour {
    
    public Rigidbody2D heroskini;
    
    private GameObject edellinenhero;
    public GameObject transofani;
    private bool osuttu = false;
    
    void Start() {
        
    }

    void Update() {
        edellinenhero = GameObject.Find("hero1");
   
}

      void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.collider.tag == "hero"  &&!osuttu)
        {
            StartCoroutine(transfo());
        }
    }

IEnumerator transfo()
    {
        osuttu = true;
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<BoxCollider2D>().enabled = false;
        Rigidbody2D seuraavahero = Instantiate(heroskini, transform.position, transform.rotation);
       // seuraavahero.GetComponent<Joystickrotaatio>().enabled = false;

        if(PlayerPrefs.GetString("ohjain")== "joo" ){
        seuraavahero.GetComponent<joystickrotaatio>().enabled = false;
        }
        else
        {
        seuraavahero.GetComponent<herokavelee>().enabled = false;
        }
        Destroy(edellinenhero);
        GameObject transani = Instantiate(transofani, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        Destroy(transani);
         
        if(PlayerPrefs.GetString("ohjain")== "joo" ){
        seuraavahero.GetComponent<joystickrotaatio>().enabled = true;
        }
        else
        {
        seuraavahero.GetComponent<herokavelee>().enabled = true;
        }

        Destroy(gameObject);
    } 

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salaovitrigger : MonoBehaviour {
    
    private GameObject ovi;
    private GameObject ovi2;
    void Start() {
        ovi = GameObject.Find("ykssuuntanenovi");
        ovi2 = GameObject.Find("ykssuuntainenovi2");
    }

    void Update() {}
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "hero")
        {
            Debug.Log("avaa");
            ovi.GetComponent<Collider2D>().enabled = false;
            ovi2.GetComponent<Collider2D>().enabled = false;
        }
    }  
    
}

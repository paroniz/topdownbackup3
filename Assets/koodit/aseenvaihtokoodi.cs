using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aseenvaihtokoodi : MonoBehaviour {
    
    public Rigidbody2D heroskini;
    
    private GameObject edellinenhero;
    
    void Start() {
        
    }

    void Update() {
        edellinenhero = GameObject.Find("hero1");
   
}

      void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.collider.tag == "hero")
        {
            Rigidbody2D seuraavahero = Instantiate(heroskini, transform.position, transform.rotation);
            Destroy(edellinenhero.gameObject);
            
            Destroy(gameObject);
        }
        
    }
}
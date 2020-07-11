using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panos : MonoBehaviour {
         
    public float lifetime = 2f;     
    public float damage = 10;      
    private GameObject fabu;

    void Start() 
    { 
        fabu = GameObject.Find("fabu1");
        Physics2D.IgnoreLayerCollision(8,9);
        
    }

    void Update() 
    {
        lifetime -= Time.deltaTime;

        if (lifetime <= 0f) 
        {   
            Destroy(gameObject);  
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if(collision.collider.tag == "ampuja1")
        {
            Physics2D.IgnoreLayerCollision(8,9);
        }
        
    }
}

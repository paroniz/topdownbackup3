using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panos : MonoBehaviour {
         
    public float lifetime = 2f;     
    public float damage = 10;      

    void Start() 
    { 
    
   
        
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
      
        
    }
}

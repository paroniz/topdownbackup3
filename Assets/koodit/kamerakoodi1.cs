using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakoodi1 : MonoBehaviour {
         
         public GameObject target;
    public Rigidbody2D target2;
   
    void Start() {
        
    }


    void Update() {


        target = GameObject.FindWithTag("hero");
        target2 = target.GetComponent<Rigidbody2D>();
        Vector3 setPosition = transform.position;
        setPosition.x = target.transform.position.x;
        setPosition.y = target.transform.position.y;
        

        
            this.transform.position = setPosition;
        
    }
}

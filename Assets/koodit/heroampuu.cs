using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroampuu : MonoBehaviour {

    public Rigidbody2D panos;
    public float luotinopeus = 80f;
    
    void Start() {}

    void Update() {
        if(Input.GetMouseButtonDown(0)) 
        {
            Rigidbody2D ammus = Instantiate(panos, transform.position, transform.rotation);
            ammus.AddForce(new Vector2(luotinopeus,0), ForceMode2D.Impulse);
        }
    }
}
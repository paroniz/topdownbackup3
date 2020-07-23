using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rahamaasta : MonoBehaviour {
    
    public float rahat;

    private GameObject t1 = null;

    void Start() {
        t1 = GameObject.Find("rahat");
    }

    void Update() {
     
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "hero")
        {
            t1.GetComponent<Text>().text = "500";
            Destroy(gameObject);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rahakoodi1 : MonoBehaviour {
    
    public float rahat;

    private GameObject t1 = null;

    void Start() {
        this.t1 = GameObject.Find("rahat");
    }

    void Update() {
       // this.t1.GetComponent<Text>().text = "0";
    }
}


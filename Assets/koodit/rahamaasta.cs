﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rahamaasta : MonoBehaviour {
    
    public static int rahat;
    private string rahamaara ="moi";
    private string uuspeli;

    private GameObject t1 = null;

    void Start() {
        t1 = GameObject.Find("rahat");
        uuspeli = PlayerPrefs.GetString("ladattu");
        if(uuspeli != "joo")
        {
            rahat = 0;
        }
    }

    void Update() {
     
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "hero")
        {
            rahat = rahat + 500;

            rahamaara = rahat.ToString();
            t1.GetComponent<Text>().text = rahamaara;
            PlayerPrefs.SetString("tuhottu1", "joo");
            Destroy(gameObject);
        }
    }
}


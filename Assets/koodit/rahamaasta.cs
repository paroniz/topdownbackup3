using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rahamaasta : MonoBehaviour {
    
    private int rahat;
    private string rahamaara ="moi";
    private int rahamaara2;
    private string uuspeli;
    private GameObject t1 = null;

    void Start() 
    {
        t1 = GameObject.Find("rahat");
        uuspeli = PlayerPrefs.GetString("ladattu");

        if(uuspeli != "joo")
        {
            rahat = 0;
        }
    }

    void Update() {}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "hero")
        {
            rahamaara = t1.GetComponent<Text>().text;
            rahamaara2 = System.Convert.ToInt32(rahamaara);
            rahamaara2 += 500;
            rahamaara = rahamaara2.ToString();
            t1.GetComponent<Text>().text = rahamaara;
            PlayerPrefs.SetString("tuhottu1", "joo");
            Destroy(gameObject);
        }
    }
}


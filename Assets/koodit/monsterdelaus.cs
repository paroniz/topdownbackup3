using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterdelaus : MonoBehaviour {
    
    public float hp = 5;
    private GameObject plasmaprojektiili;

    void Start() 
    {
        plasmaprojektiili = GameObject.Find("plasmaprojectile");
    }

    void Update() 
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "heroprojektiili")
        {
            //Debug.Log("yolo");
            hp--;
        }
    }
}
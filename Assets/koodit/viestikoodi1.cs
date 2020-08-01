using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viestikoodi1 : MonoBehaviour {
    
    private GameObject player;
    public float lifetime = 4f;

    void Start() 
    {
        player = GameObject.FindWithTag("hero");
    }

    void Update() 
    {
        Vector3 setPosition = transform.position;
        setPosition.x = player.transform.position.x;
        setPosition.y = player.transform.position.y;
        this.transform.position = setPosition;
        lifetime -= Time.deltaTime;
        if (lifetime <= 0f) 
        {   
            Destroy(gameObject);  
        }
    }
}


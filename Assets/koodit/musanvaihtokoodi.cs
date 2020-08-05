using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musanvaihtokoodi : MonoBehaviour {
    
    public AudioClip haamumusa;
    public AudioClip normimusa;
    private AudioSource audio;   
    public bool sisalle = true;

    void Start() 
    {
        //GetComponent original audio source
        audio=gameObject.GetComponent<AudioSource>();
        audio.clip = haamumusa;
        audio.volume = 1.0f;
    }

    void Update() {}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "hero"){
        if (sisalle)
        {
            audio.Play();
            Debug.Log("juuh");
        }
        else{
            audio.clip = normimusa;
            audio.Play();
        }
        }
    }
}
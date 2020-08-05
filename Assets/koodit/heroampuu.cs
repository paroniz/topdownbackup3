using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroampuu : MonoBehaviour {

    public Rigidbody2D panos;
    public float luotinopeus = 80f;
    public int asemoodi = 1;
    public float luotirotaatio = 90;
    private Vector3 herorotaatio;
    private GameObject hero;
    public AudioClip laukaus;
    private AudioSource audio;

    void Start() 
    {
      audio = gameObject.AddComponent<AudioSource>(); 
      audio.clip = laukaus;
      audio.volume = 0.3f;
    }

    void Update() 
    {
      hero = GameObject.FindWithTag("hero");
      if(Input.GetButtonDown("Fire2")) 
      { 
        if (asemoodi == 1)
        {
          Rigidbody2D ammus = Instantiate(panos, transform.position, transform.rotation);
          ammus.transform.Rotate(new Vector3(0, 0, luotirotaatio));
          herorotaatio = hero.transform.rotation.eulerAngles;  
          ammus.AddForce(ammus.transform.right * 900f * luotinopeus);
          audio.Play(); 
        }
        if(asemoodi == 2)
        {
          Rigidbody2D ammus = Instantiate(panos, transform.position + new Vector3 (0.2f,0.2f,0), transform.rotation);
          Rigidbody2D ammus2 = Instantiate(panos, transform.position, transform.rotation);
          ammus.transform.Rotate(new Vector3(0, 0, luotirotaatio));
          ammus.AddForce(-ammus.transform.right * 900f * luotinopeus);
          ammus2.transform.Rotate(new Vector3(0, 0, luotirotaatio));
          ammus2.AddForce(-ammus.transform.right * 900f * luotinopeus);
          audio.Play();  
        }
        // if (asemoodi == 3)
        //   {
        //      Rigidbody2D ammus = Instantiate(panos, transform.position+ new Vector3 (0.2f,0.2f,0), transform.rotation);
        //      ammus.transform.Rotate(new Vector3(0, 0, luotirotaatio));
        //  ammus.AddForce(lookPos * 900f * luotinopeus);
        // }
      }
    }
}
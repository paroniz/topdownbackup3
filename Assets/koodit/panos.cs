using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panos : MonoBehaviour {
         
    public float lifetime = 2f;     
    public float damage = 10;  
    public AudioClip osuma;
    private AudioSource audio;   
   // private Animator ani = null; 
    //private bool osui;
    

    void Start() 
    { 
  //  this.ani = this.GetComponent<Animator>();
   audio = gameObject.AddComponent<AudioSource>(); 
        audio.clip = osuma;
        audio.volume = 0.15f;
    }
    void Update() 
    {
        lifetime -= Time.deltaTime;

        if (lifetime <= 0f) 
        {   
            Destroy(gameObject);  
        }

    //      osui = ani.GetBool("osui");

    //    if (osui){
    //     this.transform.localScale = new Vector3 (2, 2, 2) ;
        //transform.gameObject.tag = "kuollutmonsu"; 
       // kuolinhuuto.Play();
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(osui2());

    }

       IEnumerator osui2()
    {
        audio.Play();
        //GameObject kuolinanimaatio = Instantiate(kuolinani, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject); 
    //ani.SetBool("osui", false);
    } 
}
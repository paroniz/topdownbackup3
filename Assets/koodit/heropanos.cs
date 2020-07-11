using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heropanos : MonoBehaviour {
         
    public float lifetime = 2f;     
    public float damage = 10;      
    private GameObject fabu;
    private Animator ani = null;

    void Start() 
    { 
        fabu = GameObject.Find("fabu1");
        this.ani = this.GetComponent<Animator>();
    }

    void Update() 
    {
        lifetime -= Time.deltaTime;

        if (lifetime <= 0f) 
        {   
            Destroy(gameObject);  
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.collider.tag == "seina" || collision.collider.tag == "ampuja1")
        {
             
             StartCoroutine(osui());
        }

        

        if(collision.collider.tag == "hero")
        {
            Physics2D.IgnoreLayerCollision(8,10);
        }

        if(collision.collider.tag == "heroprojektiili")
        {
            Physics2D.IgnoreLayerCollision(8,8);
        }

         
    }

   IEnumerator osui()
    {
       ani.SetInteger("osui", 1);
        //transform.gameObject.tag = "kuollutmonsu"; 
       // kuolinhuuto.Play();
        //GameObject kuolinanimaatio = Instantiate(kuolinani, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject); 
    } 


}

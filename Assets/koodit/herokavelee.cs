using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herokavelee : MonoBehaviour {
    
public Rigidbody2D panos;       
Rigidbody2D body;
GameObject kohde; 
float horizontal;
float vertical;
public float juoksunopeus = 20.0f;
public float rotaatiokerroin;
public float luotirotaatio = 90;
public float luotinopeus = 80f;
public float hp = 5;
private Vector3 mousePos;
public int asemoodi = 1;


   void Start ()
   {
      body = GetComponent<Rigidbody2D>(); 
   }

   void Update ()
   {
      body.velocity = new Vector2(0,0);
      body.angularVelocity = 0f;
      horizontal = Input.GetAxisRaw("Horizontal");
      vertical = Input.GetAxisRaw("Vertical"); 

      mousePos = new Vector3(Input.GetAxisRaw("testi1"), Input.GetAxisRaw("testi2"), 10);

     mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
      Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
      lookPos = lookPos - transform.position;
      
      float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
      this.transform.Rotate(new Vector3(0, 0, rotaatiokerroin));

      if(Input.GetButtonDown("Fire1")) 
      { 
      
         if (asemoodi == 1)
         {
            Rigidbody2D ammus = Instantiate(panos, transform.position + new Vector3 (0,0,0) , transform.rotation);
            ammus.transform.Rotate(new Vector3(0, 0, luotirotaatio));
            ammus.AddForce(lookPos * 900f * luotinopeus);
           
         }

         if (asemoodi == 2)
         {
            Rigidbody2D ammus = Instantiate(panos, transform.position + new Vector3 (0.2f,0.2f,0), transform.rotation);
            Rigidbody2D ammus2 = Instantiate(panos, transform.position, transform.rotation);
            ammus.transform.Rotate(new Vector3(0, 0, luotirotaatio));
            ammus.AddForce(lookPos * 900f * luotinopeus);
            ammus2.transform.Rotate(new Vector3(0, 0, luotirotaatio));
            ammus2.AddForce(lookPos * 900f * luotinopeus);
            
         }
         if (asemoodi == 3)
         {
            Rigidbody2D ammus = Instantiate(panos, transform.position+ new Vector3 (0.2f,0.2f,0), transform.rotation);
            ammus.transform.Rotate(new Vector3(0, 0, luotirotaatio));
            ammus.AddForce(lookPos * 900f * luotinopeus);
         }
      }
   }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "projektiili")
        {
            hp--;
        }
    }

   private void FixedUpdate()
   {  
      body.velocity = new Vector2(horizontal * juoksunopeus, vertical * juoksunopeus);
   }
}

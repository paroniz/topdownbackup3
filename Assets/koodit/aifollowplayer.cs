using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class aifollowplayer : MonoBehaviour
 {
    public Rigidbody2D panos;   
    private GameObject kohde; 
    public float nopeus = 5;
    public float luotirotaatio2 = 90;
    public float luotinopeus3 = 80f;
    public float rotaatiokerroin2 = 90f;
    public float ammussekunnit = 1f;
    public AudioClip laukaus;
    private AudioSource audio;
    public float ampumisetaisyys = 10f;

    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>(); 
        audio.clip = laukaus;
        audio.volume = 0.15f;
    }
     
    void Update()
    {
        kohde = GameObject.FindGameObjectWithTag("hero");
        Vector3 targetDir = kohde.transform.position - transform.position;
        float angle = Mathf.Atan2(targetDir.y,targetDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation,q,180);
         
        //transform.Translate(Vector3.up * Time.deltaTime * nopeus);
        this.transform.Rotate(new Vector3(0, 0, rotaatiokerroin2));



        ammussekunnit -= Time.deltaTime;
        if (ammussekunnit <= 0f) 
        {  
            float distance = Vector3.Distance (this.transform.position, kohde.transform.position);
            string distance2 = distance.ToString();
            Debug.Log(distance2);
            if(distance < ampumisetaisyys)
            {
                Ammu();
                ammussekunnit = 1f; 
            }
        }
    }

    void Ammu()
    {
        Rigidbody2D ammus3 = Instantiate(panos, transform.position, transform.rotation);
        ammus3.transform.Rotate(new Vector3(0, 0, luotirotaatio2));
        ammus3.AddForce(-ammus3.transform.right * 10f * luotinopeus3);
        audio.Play();
        
    }
}
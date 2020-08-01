using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class hissikoodi1 : MonoBehaviour {
    
    public GameObject teleani;
    private GameObject hissi;
    private GameObject alusta;
    private GameObject spacearound;
    private GameObject kohde;
    private bool kytketty1;
    private bool kytketty2;
    private GameObject tietokone1;
    private GameObject tietokone2;
    private GameObject hero;
     //private Tilemap katto2;

    void Start() 
    {
        hissi = GameObject.Find("loossi");  
        spacearound = GameObject.Find("spacearound");
        tietokone1 = GameObject.Find("tietokone1");
        tietokone2 = GameObject.Find("tietokone31");
    }

    void Update() 
    {
        kohde = GameObject.FindGameObjectWithTag("hero");
        kytketty1 = tietokone1.GetComponent<tietokonekoodi1>().kytketty;
        kytketty2 = tietokone2.GetComponent<tietokonekoodi2>().kytketty;
        hero = GameObject.FindGameObjectWithTag("hero");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.tag == "hero" && kytketty1 && kytketty2)
        {
            //Debug.Log("yolo");
            StartCoroutine(transfo());
            // hissi.transform.position = new Vector3(0, 0, -200);  
            // spacearound.transform.position = new Vector3(0, 0, -200);  
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
         if(other.tag == "hero")
        {
            Debug.Log("yolo2");
            //hissi.transform.position = new Vector3(0, 0,0);
        }
    }

    IEnumerator transfo()
    {
        //this.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("transfo");
        GameObject transani = Instantiate(teleani, transform.position, transform.rotation);
        hero.GetComponent<joystickrotaatio>().enabled = false;
        hero.GetComponent<herokavelee>().enabled = false;
        yield return new WaitForSeconds(1f);
        kohde.transform.position = new Vector3(2.09f,74.45f,0f);
        GameObject transani2 = Instantiate(teleani, hero.transform.position, transform.rotation);
        Destroy(transani);
        
        if(PlayerPrefs.GetString("ohjain")== "joo" )
        {
            hero.GetComponent<joystickrotaatio>().enabled = true;
            hero.GetComponent<herokavelee>().enabled = false;
        }
        else
        {
            hero.GetComponent<herokavelee>().enabled = true;
            hero.GetComponent<joystickrotaatio>().enabled = false;
        }
        yield return new WaitForSeconds(1f);
        Destroy(transani2);
    } 
}

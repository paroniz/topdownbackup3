using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour {
    
private GameObject hero;

public GameObject pausemenu;
    public GameObject options2;

    void Start() {
        
       
    }

    void Update() {
         hero = GameObject.FindWithTag("hero");
    }


 public void vaihto() {
    if (hero.GetComponent<herokavelee>().isActiveAndEnabled == true)
     {
     //Panel.gameObject.SetActive(false);
     hero.GetComponent<herokavelee>().enabled=false;
     hero.GetComponent<joystickrotaatio>().enabled=true;
      Debug.Log("vaihtaa2");
      }
  else
      {
      // Panel.gameObject.SetActive(true);
       hero.GetComponent<herokavelee>().enabled=true;
       hero.GetComponent<joystickrotaatio>().enabled=false;
       Debug.Log("vaihtaa1");
      }
 }

public void vaihdaoptionsiin(){
        pausemenu.SetActive(false);
        options2.SetActive(true);
}

public void vaihdatakaisin(){
        pausemenu.SetActive(true);
        options2.SetActive(false);
}
}

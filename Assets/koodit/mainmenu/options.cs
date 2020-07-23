using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour {
    
private GameObject hero;

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
      }
  else
      {
      // Panel.gameObject.SetActive(true);
       hero.GetComponent<herokavelee>().enabled=true;
       hero.GetComponent<joystickrotaatio>().enabled=false;
      }
 }
}

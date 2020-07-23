using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class options : MonoBehaviour {
    
private GameObject hero;
public GameObject firstcontrols2;
public GameObject firstcontrols3;
private bool kontrollermoodi = true;

public GameObject pausemenu;
    public GameObject options2;

    void Start() {
        
       
    }

    void Update() {
         hero = GameObject.FindWithTag("hero");
    }


 public void vaihto() {
 if  (!kontrollermoodi)
      {
      // Panel.gameObject.SetActive(true);
       hero.GetComponent<herokavelee>().enabled=true;
       hero.GetComponent<joystickrotaatio>().enabled=false;
       Debug.Log("vaihtaa1");
       kontrollermoodi = true;
       return;
      }


   else
     {
     //Panel.gameObject.SetActive(false);
     hero.GetComponent<herokavelee>().enabled=false;
     hero.GetComponent<joystickrotaatio>().enabled=true;
      Debug.Log("vaihtaa2");
      kontrollermoodi = false;
      }
 
 }

public void vaihdaoptionsiin(){
        pausemenu.SetActive(false);
        options2.SetActive(true);
        EventSystem es = EventSystem.current;
        es.firstSelectedGameObject = firstcontrols2;
        es.SetSelectedGameObject(firstcontrols2);
}

public void vaihdatakaisin(){
        pausemenu.SetActive(true);
        options2.SetActive(false);
        EventSystem es2 = EventSystem.current;
        es2.firstSelectedGameObject = firstcontrols3;
        es2.SetSelectedGameObject(firstcontrols3);
}

public void volumechange(){
        Debug.Log("placeholdervolume");
}
}

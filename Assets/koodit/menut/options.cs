using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class options : MonoBehaviour {
    
private string text;
private GameObject hero;
public GameObject firstcontrols2;
public GameObject firstcontrols3;
public GameObject vaihtoteksti;
private Color normicolor;
private Color altcolor;
private bool kontrollermoodi = true;

string texti;
string texti2;

public GameObject pausemenu;
    public GameObject options2;
        private string contru;
    void Start() {
            hero = GameObject.FindWithTag("hero");
       
        contru = PlayerPrefs.GetString("ohjain");
       if (contru == "joo") {
               vaihdaohjaimeen();
       } 
       else
       {
                vaihdanappikseen();
       }
    }

    void Update() {
         hero = GameObject.FindWithTag("hero");
    }

 

public void vaihdaohjaimeen(){
        PlayerPrefs.SetString("ohjain", "joo");
         hero.GetComponent<herokavelee>().enabled=false;
       hero.GetComponent<joystickrotaatio>().enabled=true;
}

public void vaihdanappikseen(){
        PlayerPrefs.SetString("ohjain", "ei");
         hero.GetComponent<herokavelee>().enabled=true;
       hero.GetComponent<joystickrotaatio>().enabled=false;
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

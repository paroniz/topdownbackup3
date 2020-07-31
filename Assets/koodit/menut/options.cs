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
public Text o_Text;
public Text o_Text2;
public Color o_Color;
string texti;
string texti2;

public GameObject pausemenu;
    public GameObject options2;
        private string contru;
    void Start() {
            hero = GameObject.FindWithTag("hero");
        texti = o_Text.text;
       texti2 = o_Text2.text;

        o_Text.text = "Mouse";                
        o_Text2.text = "Controller";
        contru = PlayerPrefs.GetString("ohjain");
       if (contru == "joo") {
               vaihto();
       } 
    }

    void Update() {
         hero = GameObject.FindWithTag("hero");
    }


 public void vaihto() {
 if  (!kontrollermoodi)
      {
              Color normicolor = new Color(202f/255f, 43f/255f, 176f/255f);
             Color altcolor = new Color(63f/255f, 0f/255f, 62f/255f);
              //o_Text.color = o_Color;
              o_Text2.color = normicolor;
            o_Text.color = altcolor;
              o_Text2.text = "Controller";
              
              //playerprefs!
        //vaihtoteksti = vaihtoteksti.GetComponent<mouse>.text ();
       //text.color = Color.white;

      // Panel.gameObject.SetActive(true);
       hero.GetComponent<herokavelee>().enabled=true;
       hero.GetComponent<joystickrotaatio>().enabled=false;
       Debug.Log("vaihtaa1");
       kontrollermoodi = true;
       return;
      }


   else
     {
        //      o_Text2.text = texti2;
        //        o_Text2.color = o_Color;
        //       o_Text.color = normicolor;
     //Panel.gameObject.SetActive(false);
     Color normicolor = new Color(202f/255f, 43f/255f, 176f/255f);
      Color altcolor = new Color(63f/255f, 0f/255f, 62f/255f);
                 o_Text.color = normicolor;
              o_Text2.color = altcolor;
              o_Text2.text = "Controller";
              o_Text.text = "Mouse";

    // hero.GetComponent<herokavelee>().enabled=false;
     //hero.GetComponent<joystickrotaatio>().enabled=true;
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

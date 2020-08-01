using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ohjainvalikkohighlight : MonoBehaviour {
    
public GameObject firstcontrols2;

    void Start() 
    {
        EventSystem es = EventSystem.current;
        es.firstSelectedGameObject = firstcontrols2;
        es.SetSelectedGameObject(firstcontrols2);
    }

    void Update() {}
}

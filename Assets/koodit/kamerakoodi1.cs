using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakoodi1 : MonoBehaviour {
         
    private GameObject target;
    private Rigidbody2D target2;
    string ladattu;
    string tuhottu;
    public GameObject rahatscreeni;
    public GameObject rahatukku;
   
    void Start() 
    {
        Time.timeScale = 1f;
        ladattu = PlayerPrefs.GetString("ladattu");
        tuhottu = PlayerPrefs.GetString("tuhottu1");
    
        // if(ladattu =="joo")
        // {
        //     target = GameObject.FindWithTag("hero");
        //     target.GetComponent<herodelaus>().hp = PlayerPrefs.GetInt("hp"); 
        //     rahatscreeni.GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetString("rahat");
        //     float playerPositionX = PlayerPrefs.GetFloat("playerPositionX");
        //     float playerPositionY = PlayerPrefs.GetFloat("playerPositionY");
        //     Vector3 playerPosition = new Vector3(playerPositionX, playerPositionY);
        //     target.transform.position =  playerPosition;
        
        //     if(tuhottu =="joo")
        //     {
        //         Destroy(rahatukku);
        //     }
        // }
        
        // else
        // {
        //     Debug.Log("ei ladattu");
        // }
    }

    void Update() 
    {
        target = GameObject.FindWithTag("hero");
        target2 = target.GetComponent<Rigidbody2D>();
        Vector3 setPosition = transform.position;
        setPosition.x = target.transform.position.x;
        setPosition.y = target.transform.position.y;
        this.transform.position = setPosition;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tallennusskripti : MonoBehaviour {
    
    private bool triggered;
    private GameObject player;
    public GameObject rahatscreeni;
    public bool ladattu = false;
    int hp;
    string rahat;

    void Start() {}

    void Update() 
    {
        player = GameObject.FindGameObjectWithTag("hero");

        if (triggered && Input.GetKeyDown(KeyCode.E))
        {
            Save();
        }
    }

    public void Save() 
    {
        //Vector3 playerPosition = player.GetPosition();
        //int moneyamount = player.GetMoneyAmount();
        Vector3 playerPosition = player.transform.position;
        Debug.Log("savetesti");
        Debug.Log(playerPosition);
        hp = player.GetComponent<herodelaus>().hp;
        rahat = rahatscreeni.GetComponent<UnityEngine.UI.Text>().text;
        Debug.Log(rahat);
        PlayerPrefs.SetFloat("playerPositionX", playerPosition.x);
        PlayerPrefs.SetFloat("playerPositionY", playerPosition.y);
        PlayerPrefs.SetInt("hp", hp);
        PlayerPrefs.SetString("rahat", rahat);
        PlayerPrefs.SetInt("savettu", 1);
        PlayerPrefs.Save();
    }

    public void Load() 
    {
        if(PlayerPrefs.HasKey("playerPositionX") && PlayerPrefs.GetInt("savettu")==1)
        {
            SceneManager.LoadScene("ekascene");
             //player2 = GameObject.FindGameObjectWithTag("hero");
            float playerPositionX = PlayerPrefs.GetFloat("playerPositionX");
            float playerPositionY = PlayerPrefs.GetFloat("playerPositionY");
            Vector3 playerPosition = new Vector3(playerPositionX, playerPositionY);
            Debug.Log(playerPosition);
            Debug.Log("loading");
            ladattu = true;
            PlayerPrefs.SetString("ladattu", "joo");
        }
        else
        {
            Debug.Log("no save");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "hero")
        {
            triggered = true;
        }
    }  
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "hero")
        {
            triggered = false;
        }
    }  
}

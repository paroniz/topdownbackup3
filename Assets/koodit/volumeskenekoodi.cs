using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class volumeskenekoodi : MonoBehaviour {
    
    int volume;
    float currentvolume;

    void Start() {

        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }

    void Update() {}

    public void VolumeUp()
    {

       currentvolume = PlayerPrefs.GetFloat("volume");
       if (currentvolume< 1.5f)
       {
       currentvolume += 0.1f;
       Debug.Log("volumeup");
        PlayerPrefs.SetFloat("volume", currentvolume);
         AudioListener.volume = PlayerPrefs.GetFloat("volume");
       }
    }

    public void VolumeDown()
    {
        currentvolume = PlayerPrefs.GetFloat("volume");
       currentvolume -= 0.1f;

          Debug.Log("down");
        PlayerPrefs.SetFloat("volume", currentvolume);
         AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}

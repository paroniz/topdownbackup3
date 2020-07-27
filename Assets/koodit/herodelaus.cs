using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class herodelaus : MonoBehaviour {
    
    public AudioClip kuolinaani;
    public GameObject kuolinani;
    public GameObject sydan2;
    public GameObject sydan1;
    private GameObject heart3;
    private GameObject vaihdasydan;
    private GameObject holderi;
    private GameObject holderi2;
    private GameObject kamera;
    private GameObject hptext;
    private AudioSource audio;
    private bool osunut;
    private bool tippunut;
    private bool kuollut = false;
    private bool tuhottu1 = false;
    private bool tuhottu2 = false;
    private float iskutime;  
    public int hp = 10; 
    private string hpstring;

    void Start() {
        audio = gameObject.AddComponent<AudioSource>(); 
        audio.clip = kuolinaani;
        audio.volume = 1.0f;

        heart3 =  GameObject.Find("3heart");
        kamera =  GameObject.Find("kamera");
        hptext = GameObject.Find("hpui");
    }

    void Update() 
    {
        // if(this.transform.position.y < -6.5f && !tippunut)
        // {
        //     tippunut = true;
        //     hp--;
        //     audio.Play();
        //     if (hp > 0) 
        //     {
        //     this.transform.position = new Vector2(-7.48f, -0.31f);
        //     kamera.transform.position = new Vector3(0, 0, -10);
        //     tippunut = false;
        //     }
        // }

        // iskutime -= Time.deltaTime;
        // if (iskutime <= 0f) 
        // {   
        //     osunut = false;
        // }

        if (hp <= 0)
        {
            hp = 0;
            kuollut = true;
            StartCoroutine(kuolema());
        }

        // if (hp < 3 && !tuhottu1)
        // {
        //     tuhottu1 = true;
        //     GameObject vaihdasydan = Instantiate(sydan2, kamera.transform.position + new Vector3(-7.23f, 4.05f, 11f), transform.rotation);
        //     vaihdasydan.transform.parent = kamera.transform;
        //     holderi = vaihdasydan;
        //     Destroy(heart3);
        // }
    


       // if (hp < 2 && !tuhottu2)
       // {
           // tuhottu2 = true;
           // GameObject vaihdasydan2 = Instantiate(sydan1, kamera.transform.position + new Vector3(-7.931f, 4.05f, 11f), transform.rotation);
           // vaihdasydan2.transform.parent = kamera.transform;
           // holderi2 = vaihdasydan2;
           // Destroy(holderi);

        hpstring = hp.ToString();
        hptext.GetComponent<Text>().text = hpstring;

        }
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.collider.tag == "projektiili")
        {
           // audio.Play();
           // osunut = true;
           // iskutime = 1.5f;
           Debug.Log("osui");
            hp--;
        }

        // if(collision.collider.tag == "arkku")
        // {
        //     GetComponent<Renderer>().enabled = false;
        // }

        // if(collision.collider.tag == "kuollutmonsu")
        // {}
    }

    IEnumerator kuolema()
    {
        //Destroy(holderi2);
       // GameObject kuolinanimaatio = Instantiate(kuolinani, transform.position, transform.rotation);
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadScene("gameover");
    }   
}

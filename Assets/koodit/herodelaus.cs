using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herodelaus : MonoBehaviour {
    
    void Start() {}

    void Update() {}

    void OnCollisionEnter2D(Collision2D collision)
    {
    //     if(!osunut)
    //     {
    //         GetComponent<AudioSource>().Play();
    //         osunut = true;
    //         iskutime = 1.5f;
    //         hp--;
    //     }

    //     if(collision.collider.tag == "arkku")
    //     {
    //         GetComponent<Renderer>().enabled = false;
    //     }

    //     if(collision.collider.tag == "kuollutmonsu")
    //     {}
    // }

    //  IEnumerator kuolema()
    // {
    //     Destroy(holderi2);
    //     GameObject kuolinanimaatio = Instantiate(kuolinani, transform.position, transform.rotation);
    //     GetComponent<Renderer>().enabled = false;
    //     yield return new WaitForSeconds(1.6f);
    //     SceneManager.LoadScene("tappioskene");
    // }   
}
}

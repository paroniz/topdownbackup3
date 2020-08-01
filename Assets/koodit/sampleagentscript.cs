using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleagentscript : MonoBehaviour {
    
    public GameObject target;
    public Rigidbody2D target2;
    UnityEngine.AI.NavMeshAgent agent;
    private GameObject kohde; 
    public float hyokkaysetaisyys = 10f;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    void Update() {
        kohde = GameObject.FindGameObjectWithTag("hero");
        float distance = Vector3.Distance (this.transform.position, kohde.transform.position);
            string distance2 = distance.ToString();
            Debug.Log(distance2+ "Moi");
            if(distance < hyokkaysetaisyys)
            {
                
            
        target = GameObject.FindWithTag("hero");
       target2 = target.GetComponent<Rigidbody2D>();
        agent.SetDestination (target2.position);
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleagentscript : MonoBehaviour {
    
    public GameObject target;
    public Rigidbody2D target2;
    UnityEngine.AI.NavMeshAgent agent;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    void Update() {
        target = GameObject.FindWithTag("hero");
       target2 = target.GetComponent<Rigidbody2D>();
        agent.SetDestination (target2.position);
    }
}

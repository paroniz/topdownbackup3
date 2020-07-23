using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleagentscript : MonoBehaviour {
    
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    void Update() {
        agent.SetDestination (target.position);
    }
}

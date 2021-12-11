using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    //destination marker reference
    public GameObject markerGoal;
    //parent position
    Vector3 parentPos;
    //navmesh component reference
    UnityEngine.AI.NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (markerGoal.active)
        {
            Debug.Log("test");
            Debug.Log(markerGoal.transform.parent.position);
            parentPos = markerGoal.transform.parent.position;
            agent.SetDestination(parentPos);
        }
    }
}

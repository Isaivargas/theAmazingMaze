using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour
{

    [SerializeField]
    private Transform[] points;

    private int destinationPoint=0;

    private NavMeshAgent agent ;

    [SerializeField]

    private float minRemainingDistance = 1.5f;


    public float lookRadius = 10f;

    Transform target;


    // Start is called before the first frame update
    void Start()
    {
        //Reference to the player 
        target = player.instance.Player.transform;

        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        GoToNextPoint();
    }


    void GoToNextPoint()
    {
        if (points.Length == 0) {
            Debug.LogError("Error not destination ");
            enabled = false;
            return;
        }

        agent.destination = points[destinationPoint].position;
        destinationPoint = (destinationPoint + 1) % points.Length;
    }


    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < minRemainingDistance)
        {
            GoToNextPoint();
        }


        float distance = Vector3.Distance(target.position,transform.position);


        if (distance <= lookRadius )
        {
            agent.SetDestination(target.position);
        }


    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] public GameObject[] waypoints;
    public int currentWaypointIndex = 0;
    private Animator Anim_Enemy;
    [SerializeField] private float speed = 2f;

    void Start()
    {
        Anim_Enemy = GetComponent<Animator>();
        
    }

    void Update()
    {

        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
           {
            

            currentWaypointIndex++;

                if (currentWaypointIndex >= waypoints.Length)
                {

                    currentWaypointIndex = 0;

                }
           }
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);        
    }
    }


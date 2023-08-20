using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] public GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    private SpriteRenderer SpRnd_Enemy;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                
                currentWaypointIndex = 0;
                Debug.Log(waypoints.Length);
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
       // Flip();

    }

    /*private void Flip()
    {

        if(Vector2.Distance(waypoints[1].transform.position, transform.position) == 0f)
        {

            SpRnd_Enemy.flipX = true;

        }else if(Vector2.Distance(waypoints[2].transform.position, transform.position) == 0f){
            SpRnd_Enemy.flipX = false;
        }
    }*/

}

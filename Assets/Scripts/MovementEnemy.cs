using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    private Animator Anim_Enemy;
    [SerializeField] private float speed = 2f;
    void Start()
    {
        Anim_Enemy = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void UpdateMovement()
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

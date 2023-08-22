using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flip_Enemies : MonoBehaviour
{

    private SpriteRenderer SpRnd_Enemy;
    public WaypointFollower EnemyMovement;

    // Start is called before the first frame update
    void Start()
    {
        SpRnd_Enemy = GetComponent<SpriteRenderer>();    }

    // Update is called once per frame
    void Update()
    {

        if (EnemyMovement.currentWaypointIndex > 0)
             {

                 SpRnd_Enemy.flipX = true;

             }
         else {
                 SpRnd_Enemy.flipX = false;
             }

    }



}


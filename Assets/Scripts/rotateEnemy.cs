using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEnemy : MonoBehaviour
{

    public SpriteRenderer RinoLR;
   


    private void Start()
    {

        RinoLR = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("reverseL"))
        {
            RinoLR.flipX = true;
        }

        else if (collision.gameObject.CompareTag("reverseR"))
        {
            RinoLR.flipX = false;
        }
    }

    

}
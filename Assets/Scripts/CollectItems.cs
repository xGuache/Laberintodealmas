using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    public AudioSource Collected;
    private int Cara = 0;
    //private string Object_Tag;
 
    [SerializeField] private TextMeshProUGUI CaraText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Red_Elixir"))
        {
            
            Destroy(collision.gameObject);
           
        }

        if (collision.gameObject.CompareTag("Cara"))
        {
            Destroy(collision.gameObject);
            Collected.Play();
            Cara++;
            CaraText.text = "Cara: " + Cara;
            //Debug.log("Cara; " + Cara);
           
        }

        /*switch (collision.gameObject.CompareTag(Object_Tag))
        {
            case "Red_Elixir":
                Destroy(collision.gameObject);
                break;
            case "Cara":
                Destroy(collision.gameObject);
                break;
            default:
                // code block
                break;
        }*/

    }

 }

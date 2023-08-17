using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    public AudioSource Collected;
    public string TagObject;
    private int Cara = 0;

 
    [SerializeField] private TextMeshProUGUI CaraText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.CompareTag("Cara"))
        {
            Collected.Play();
            Destroy(collision.gameObject);
            Cara++;
            //Debug.Lod("cara: " + Cara);
            CaraText.text = "Cara: " + Cara;
        }*/

        switch (collision.gameObject.tag)
        {
            case "Blue_Elixir":
                Destroy(collision.gameObject);

                break;

            case "Red_Elixir":
                Destroy(collision.gameObject);

                break;

            case "Green_Elixir":
                Destroy(collision.gameObject);

                break;
            case "Rainbow_Elixir":
                Destroy(collision.gameObject);

                break;

            case "Cara":
                Destroy(collision.gameObject);
                Collected.Play();
                Cara++;
                CaraText.text = "Cara: " + Cara;
                break;
            default:
                Debug.Log("kha");
            break;
        }
    }
}

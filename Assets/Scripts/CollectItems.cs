using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    public AudioSource Collected;
    private int Cara = 0;

 
    [SerializeField] private TextMeshProUGUI CaraText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cara"))
        {
            Collected.Play();
            Destroy(collision.gameObject);
            Cara++;
            //Debug.Lod("cara: " + Cara);
            CaraText.text = "Cara: " + Cara;
        }
    }
}

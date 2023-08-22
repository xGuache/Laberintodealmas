using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D RB_Player;
    private Animator Anim_Player;
    public AudioSource DeathSound;
    
    private void Start()
    {
        RB_Player = GetComponent<Rigidbody2D>();
        Anim_Player = GetComponent<Animator>();
    }

    //Function for compare the Tag Object which player will be collisioning.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            //Debug.Log(collision.gameObject.CompareTag("Trap"));
            Die();
        }
    }

    //Function for play death animation
    private void Die()
    {
        //DeathSound.Play();
        RB_Player.bodyType = RigidbodyType2D.Static;
        Anim_Player.SetTrigger("Death");
        DeathSound.Play();
    }
   
    //Reload Current Scene
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}

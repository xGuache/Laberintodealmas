using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private Rigidbody2D RB_Player;
    private Animator Anim_Player;
    private SpriteRenderer SpRnd_Player;
    private BoxCollider2D BxCol2D_Player;



    [SerializeField] private LayerMask jumpableGround;

    private float Mov_X = 0f;
    
    [SerializeField] private float Mov_Speed = 8f;
    [SerializeField] private float JumpForce = 7f;

    private enum MovementState {Idle, Run, Jump, Fall};
    private MovementState AnimState;


    // Start is called before the first frame update
    void Start()
    {
        BxCol2D_Player = GetComponent<BoxCollider2D>();
        RB_Player = GetComponent<Rigidbody2D>();
        Anim_Player = GetComponent<Animator>();
        SpRnd_Player = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Mov_X = Input.GetAxis("Horizontal");
        RB_Player.velocity = new Vector2(Mov_X * Mov_Speed, RB_Player.velocity.y);


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {

            RB_Player.velocity = new Vector2(RB_Player.velocity.x, JumpForce);
        }

        UpdateAnimation();
    }

     private void UpdateAnimation()
     {

        
        
            if (Mov_X > 0f)
            {
                SpRnd_Player.flipX = true;
                AnimState = MovementState.Run;
            }
            else if (Mov_X < 0f)
            {
                AnimState = MovementState.Run;
                SpRnd_Player.flipX = false;
            }
            else
            {
                AnimState = MovementState.Idle;
            }

            if (RB_Player.velocity.y > 0.1f)
            {
                AnimState = MovementState.Jump;
            }
            else if (RB_Player.velocity.y < -0.1f)
            {
                AnimState = MovementState.Fall;
            }

             Anim_Player.SetInteger("AnimState", (int)AnimState);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(BxCol2D_Player.bounds.center, BxCol2D_Player.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

}

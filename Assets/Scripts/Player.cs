using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;
    private Rigidbody2D myBody;
    private Animator anim;
    private SpriteRenderer sr;
    private string WALK_ANIMATION = "walk";
    private bool isGrounded;
    private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }
    void Start()
    {
        
    }

    void Update()
    {
        PlayerMoveKeyBorad();
        AnimatePlayer();
        PlayerJump();
    }

    void PlayerMoveKeyBorad() {
    movementX = Input.GetAxisRaw("Horizontal");
    transform.position +=  new Vector3(movementX , 0f, 0f) * moveForce * Time.deltaTime;
    }
    void AnimatePlayer() {
        if (movementX> 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }else if (movementX<0)
        {
                        anim.SetBool(WALK_ANIMATION, true);
                                    sr.flipX = true;


        }else
        {
                        anim.SetBool(WALK_ANIMATION, false);

        }
    }

    void PlayerJump() {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {

isGrounded= false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}

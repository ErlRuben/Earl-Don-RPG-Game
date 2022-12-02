using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    Animator anim;
    Vector2 input;

    public CharacterController controller;
    private float speed = 2.0f;
    public float gravity = -9.81f;
    public float jump = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    Vector3 playerVelocity;
    bool isGrounded;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationMove();

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && playerVelocity.y < 0){
            playerVelocity.y = -2f;

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Jump") && isGrounded){
            playerVelocity.y=Mathf.Sqrt(jump * -2f * gravity);
            anim.SetBool("Jump", true);
        }
        else if(Input.GetButtonUp("Jump") && !isGrounded){
            anim.SetBool("Jump", false);
        }
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        playerVelocity.y += gravity*Time.deltaTime;
        controller.Move(playerVelocity*Time.deltaTime);
    }
    void AnimationMove(){
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        anim.SetFloat("MoveX", input.x);
        anim.SetFloat("MoveY", input.y);
    }


}

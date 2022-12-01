using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    private CharacterController characterController;
    public Animator anim;
    [SerializeField] private float moveSpeed;
    [SerializedField] private float walkSpeed;
    [SerializedField] private float runSpeed;

    private  Vector3 moveDirection;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //2 or more input
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Space)){
            anim.SetInteger("BasicMovement", 6);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)){
            anim.SetInteger("BasicMovement", 2);
        }
        else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftControl)){
            anim.SetInteger("BasicMovement", 5);
        }
        else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space)){
            anim.SetInteger("BasicMovement", 6);
        }
        else if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Space)){
            anim.SetInteger("BasicMovement", 7);
        }
        //Basic
        else if(Input.GetKey(KeyCode.LeftControl)){
            anim.SetInteger("BasicMovement", 4);
        }
        else if(Input.GetKey(KeyCode.W)){
            anim.SetInteger("BasicMovement", 1);
        }
        else if(Input.GetKey(KeyCode.A)){
            anim.SetInteger("BasicMovement", 1);
        }
        else if(Input.GetKey(KeyCode.S)){
            anim.SetInteger("BasicMovement", 3);
        }
        else if(Input.GetKey(KeyCode.D)){
            anim.SetInteger("BasicMovement", 1);
        }
        else if(Input.GetKeyDown(KeyCode.Space)){
            //anim.SetInteger("BasicMovement", 7);
            Debug.Log("Press Space");
            velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }
        else{
            anim.SetInteger("BasicMovement", 0);
        }   
    }
    private void Move() {
        float moveZ = Input.GetAxis("Vertical");
        moveDirection = new Vector3(0,0,moveZ);
        moveDirection += walkSpeed;
        if(moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift)){
            Walk();
        }
        else if(moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift)){
            Run();
        }
        else if(moveDirection==Vector3.zero){
            Idle();
        }
        characterController.Move(moveDirection*Time.deltaTime);
    }
    private void Idle(){
        
    }
    private void Walk(){
        moveSpeed = walkSpeed;
    }
    private void Run(){
        moveSpeed = runSpeed;
    }
}

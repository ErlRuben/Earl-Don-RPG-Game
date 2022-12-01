using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public float speed =1f;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //2 or more input
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Space)){
            anim.SetInteger("BasicMovement", 6);
        }
        else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)){
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
        else if(Input.GetKey(KeyCode.Space)){
            anim.SetInteger("BasicMovement", 7);
        }
        else{
            anim.SetInteger("BasicMovement", 0);
        }

        
    }
}

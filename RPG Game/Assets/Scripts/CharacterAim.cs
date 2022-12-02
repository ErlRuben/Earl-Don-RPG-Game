using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRot;
    float yRot;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update() {
        float mouseX = Input.GetAxis("Mouse X") *sensX* Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") *sensX* Time.deltaTime;
        yRot += mouseX;
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot,-70f,40f);
        transform.rotation = Quaternion.Euler(xRot,yRot,0);
        orientation.rotation = Quaternion.Euler(0,yRot,0);
    }
    
    // public float mouseSens = 100f;
    // public Transform playerBody;
    // float xRot = 0f;
    // void Start()
    // {
    //     Cursor.lockState = CursorLockMode.Locked;
    //     Cursor.visible = false;
    // }

    // private void Update() {
    //     float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
    //     float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
    //     xRot -= mouseY;
    //     xRot = Mathf.Clamp(xRot,-90f,90f);
    //     transform.rotation = Quaternion.Euler(xRot,0f,0f);
    //     playerBody.Rotate(Vector3.up * mouseX);
    // }
    // public Vector2 sens;
    // public Transform orientation;
    // public Vector2 rot;
    // void Start()
    // {
    //     Cursor.lockState = CursorLockMode.Locked;
    //     Cursor.visible = false;
    // }

    // private void Update() {
    //     Vector2 MouseInput = new Vector2{
    //         x = Input.GetAxis("Mouse X"),
    //         y = Input.GetAxis("Mouse Y")
    //     };
    //     rot.x -= MouseInput.y  * sens.y;
    //     rot.y += MouseInput.x  * sens.x;
    //     rot.x = Mathf.Clamp(rot.x,-70f,70f);
    //     transform.eulerAngles = new Vector3 (0f,rot.y,0f);
    //     orientation.localEulerAngles = new Vector3(rot.x,0f,0f);
    // }
}

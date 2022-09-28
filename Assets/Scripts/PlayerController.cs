using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),
            0, Input.GetAxis("Vertical"));
        //SimpleMove is a method that makes the character move in the given direction
        //But it doesn't allow the character to move through objects
        characterController.SimpleMove(moveDirection * moveSpeed);
        //OLD Code
        //Vector3 pos = transform.position;   //Gets the position of the Current Object (the one it is attached to)
        //pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;  //The Input.GetAxis returns only 1 or -1
        //pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        //transform.position = pos;
    }
}
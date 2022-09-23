using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;   //Gets the position of the Current Object (the one it is attached to)
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;  //The Input.GetAxis returns only 1 or -1
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject followTarget;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followTarget != null)
        {
            transform.position = Vector3.Lerp(transform.position,               //Lerp takes three parameters: start position in 3D space, the end position, and
                followTarget.transform.position, Time.deltaTime * moveSpeed);   //a value between 0 and 1 that represents a point between the starting and ending positions
                                                                                //0 returns the start and 1 the end - A number between them makes the transition smoothly

        }
    }
}

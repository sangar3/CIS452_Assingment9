using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    private int desiredLane = 1; //0=:left , 1::middle 2:right

    void Start()
    {
       
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        direction.z = forwardSpeed;
    }
    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }
}

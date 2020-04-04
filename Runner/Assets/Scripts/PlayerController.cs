using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;

    public AudioClip carsfx;
    private int desiredLane = 1; //0=:left , 1::middle 2:right
    public float laneDistance = 4; // the dsitance between two lanes 
    [Header("Car Stats")]
    public float jumpForce;
    public float Gravity = -20;
    public int health = 100;
    public float maxSpeed;
    public float forwardSpeed;
    public float SidetoSideSpeed = 500f;
    void Start()
    {
       
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        if(forwardSpeed< maxSpeed) //increase speed of car
        {
            forwardSpeed += 0.1f * Time.deltaTime;
        }
      

        direction.z = forwardSpeed;
        //Jumping 
       
        
        if(controller.isGrounded)
        {
            //direction.y = -1;

            if (Input.GetKeyDown("space"))
            {
                AudioManager.Instance.PlaySFX(carsfx, 3.0f);
                Jump();
            }
        }
        else
        {
            direction.y += Gravity * Time.deltaTime;
        }
        //gather the inputs on which lane we should be 
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Debug.Log("right arrow pressed");
            
            desiredLane++;//rightlane
            if( desiredLane == 3)
            {
                desiredLane = 2;

            }

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            //Debug.Log("left arrow pressed");
            desiredLane--;//leftlane
            if (desiredLane == -1)
            {
                desiredLane = 0;

            }

        }

        //calcute new player position

        Vector3 targetposition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if( desiredLane == 0)
        {
            //player needs to on the left
            targetposition += Vector3.left * laneDistance;
        }
        else if(desiredLane == 2)
        {
            //player needs to on the right
            targetposition += Vector3.right * laneDistance;
        }
        //transform.position = Vector3.Lerp(transform.position, targetposition, SidetoSideSpeed*Time.deltaTime);
        if (transform.position == targetposition)
            return;
        Vector3 diff = targetposition - transform.position;
        Vector3 MoveDir = diff.normalized * 25 * Time.deltaTime;
        if (MoveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(MoveDir);
        else
            controller.Move(diff);
    }
    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }

    private void Jump()
    {
        direction.y = jumpForce;

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Obstacle")
        {
            health = health - 1;

            if(health<=50)
            {
                Debug.Log("damged");
                GameManager.damaged = true;
                if (health <= 0)
                {
                    Debug.Log("gameover");
                    GameManager.damaged = false;
                    GameManager.gameover = true;
                }
            }
            
            Debug.Log("Health is" + health);
        }
    }
}

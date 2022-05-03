using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VariableJoystick joy;
    public float speed;

    private Rigidbody playerRb;
    public Animator anim;
    private Vector3 moveVec;
    private CharacterController _playerController;

    public bool runChecking;
    
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        _playerController = GetComponent<CharacterController>();
    }

    public void FixedUpdate()
    {
        float x = joy.Horizontal;
        float z = joy.Vertical;
        
        moveVec = new Vector3(x, 0, z) * speed * Time.deltaTime;
        _playerController.Move(moveVec);

        Quaternion dirQuat = Quaternion.LookRotation(moveVec);
        Quaternion moveQuat = Quaternion.Slerp(playerRb.rotation, dirQuat, 0.3f);
        playerRb.MoveRotation(moveQuat);

        playerRb.velocity = new Vector3(joy.Horizontal * speed, playerRb.velocity.y, joy.Vertical * speed);

        if (joy.Horizontal != 0f || joy.Vertical != 0f)
        {
            anim.SetBool("IsRun", true);
            transform.rotation = Quaternion.LookRotation(playerRb.velocity);
        }
        else
        {
            anim.SetBool("IsRun",false);
        }

    }
    
    

}

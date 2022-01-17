using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private CharacterController controller;

    /*
     public bool isGrounded;

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
     
     */

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * Speed * Time.deltaTime);

        /*
         if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 400, 0));
        }
         */


        /*_direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        Debug.Log(_direction);*/
        //transform.LookAt(moveDirection + transform.position);
    }

    void FixedUpdate()
    {
        //transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed;
    }
    


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlController : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    private Vector3 playerVelocity;
    [SerializeField] private bool groundedPlayer;
    [SerializeField] private float Speed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float gravityValue;

    /*
      private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }
     */


    /*
     void OnCollisionEnter(Collider other)
    {
        groundedPlayer = true;
    }
     */



    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        /*
         Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * Speed);         
         */

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * Speed * Time.deltaTime);


        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        if (Input.GetKeyDown(KeyCode.Space) && groundedPlayer)
        {
            groundedPlayer = false;
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);            
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);       
    }
}

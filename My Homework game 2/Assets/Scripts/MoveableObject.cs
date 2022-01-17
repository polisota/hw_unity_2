using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public int gr;
    public float grabPower;
    public float throwPower;
    public float RayDistance;

    [SerializeField] private bool Grab;
    [SerializeField] private bool Throw;
    public Transform offset;
    public Camera camera;
    RaycastHit hit;


    private void Start()
    {
        gr = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, RayDistance);
            if (hit.rigidbody)
            {
                gr += gr;

                switch (gr)
                {
                    case 1:
                        Grab = true;
                        break;

                    case 2:
                        Grab = false;
                        break;

                    default:
                        break;
                }

                if (gr == 3)
                {
                    gr = 0;
                }

                if (Grab == false)
                {
                    gr = 0;
                }
            }
            Debug.Log(gr);
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (Grab)
            {
                gr = 0;
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (Grab)
            {
                Grab = false;
                Throw = true;
            }
        }

        if (Grab)
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.velocity = (offset.position - (hit.transform.position + hit.rigidbody.centerOfMass)) * grabPower;

            }
        }

        if (Throw)
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.velocity = camera.ScreenPointToRay(Input.mousePosition).direction * throwPower;
                Throw = false;
            }
        }
    }

    private void Grab1()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit, RayDistance);
        if (hit.rigidbody)
        {
            Grab = true;
        }
    }
    /*
     [SerializeField] private float gravityValue;
    [SerializeField] private float throwPower;
    public float rayDistance;
    [SerializeField] private boolean grab;
    [SerializeField] private boolean push;


    // Update is called once per frame
    void Update()
    {
        
    }
     */


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    public float rayDistance;
    public GameObject obj;
    public CameraLook scr;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, ray.direction * rayDistance);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, rayDistance))
            {
                obj.SetActive(true);
                scr.enabled = false; ;
            }
        }

        Cursor.visible = true;

    }

}

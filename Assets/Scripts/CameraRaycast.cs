using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{

    private void FixedUpdate()
    {
        // Create a raycast hit vaiable to store our results
        RaycastHit hit;

        // A ray that goes from screen coordinates forward in our world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Conduct our Raycast
        if (Physics.Raycast(ray, out hit))
        {
            hit.collider.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
        }
        else
        {
            Debug.Log("Raycast is not hitting anything");
        }
    }

}

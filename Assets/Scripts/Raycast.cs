using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // This function is called every fixed framerate
    private void FixedUpdate()
    {
        // Create a ray variable to raycast with
        Ray ray = new Ray(transform.position, transform.forward);

        // RaycastHit variable to store the results of our raycast
        RaycastHit hit;

        // Conduct the raycast and respond to the hit state
        if(Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(transform.position, ray.direction * hit.distance, Color.yellow);
        } 
        else
        {
            Debug.DrawRay(transform.position, ray.direction * 1000, Color.white);
        }
    }

}

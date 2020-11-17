using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class Rotation : MonoBehaviour
{
    public int speed = 1;
    public float speed2;
    float hitdist = 0.0f;

    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);


        if (playerPlane.Raycast(ray, out hitdist))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Vector3 targetPoint = ray.GetPoint(hitdist);
                Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed2 * Time.deltaTime);
            }
        }



    }
}
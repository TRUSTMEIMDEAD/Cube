using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camm : MonoBehaviour
{

    public GameObject plaer;
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - plaer.transform.position;
    }

    void LateUpdate()
    {
        transform.position = plaer.transform.position + offset;
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
    }
}

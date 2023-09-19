using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColision : MonoBehaviour
{
    // 1. 나한테 RigidBody 가 있어야 한다 is Kinematic : Off
    // 2. 나한테 Colider가 있어야 한다 isTrigger : off
    // 3. 상태한테 Colider 가 있어야 한다 isTrigger : off
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
    }
}

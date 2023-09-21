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
        //Debug.Log("Collision!");
    }

    // 1. 둘다 Colider 가 있어야한다
    // 2. 둘 중 하나는 isTrigger : on
    // 3. 둘 중 하나는 RigidBody 가 있어야 한다.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
    }
    
    private void Start()
    {
        
    }

    private void Update()
    {
        // Local <-> World <-> Viewport <-> Screen (화면)
        //Debug.Log(Input.mousePosition); // Screen
        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // ViewPort
        #region World
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");;
            //int mask = ((1 << 8) | (1 << 9));
            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                
                Debug.Log($"RayCast Camera @ {hit.collider.gameObject.name}");
            }
        }
        #endregion
       
    }
}

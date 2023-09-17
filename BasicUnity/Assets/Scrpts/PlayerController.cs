using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f ;
    private void Start()
    {
        
    }

    // GameObject(Player)
        // Transform
        // PlayerController
    private void Update()
    {
        // Local -> World
        // TransformDirection
        
        // World -> Loacl
        // InversTransformDirection
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward * (Time.deltaTime * _speed)) ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.TransformDirection(Vector3.back * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.TransformDirection(Vector3.left * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right * (Time.deltaTime * _speed));
        }
    }
}

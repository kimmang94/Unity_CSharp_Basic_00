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
            transform.Translate(Vector3.forward * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate((Vector3.back * (Time.deltaTime * _speed)));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector3.left * (Time.deltaTime * _speed)));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector3.right * (Time.deltaTime * _speed)));
        }
    }
}

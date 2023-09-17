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

    private float _yAngle = 0.0f;
    private void Update()
    {
        _yAngle += Time.deltaTime * _speed;
        
        // 절대 회전 값
        //transform.eulerAngles = new Vector3(0f, _yAngle, 0f);
        
        // +- delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100f , 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0f, _yAngle, 0f));
        //Quaternion qt = transform.rotation;
        
        if (Input.GetKey(KeyCode.W))
        {
           transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.3f);
           transform.position += (Vector3.forward * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.3f);
            transform.position += ((Vector3.back * (Time.deltaTime * _speed)));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.3f);
            transform.position += ((Vector3.left * (Time.deltaTime * _speed)));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.3f);
            transform.position += ((Vector3.right * (Time.deltaTime * _speed)));
        }
    }
}

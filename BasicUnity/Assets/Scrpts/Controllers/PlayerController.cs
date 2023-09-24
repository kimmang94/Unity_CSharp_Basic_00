using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;

    private bool _moveToDest = false;
    private Vector3 _destPos;
    private float dirMinLength = 0.0001f;
    private void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;
        Managers.Input.MouseAction -= OnMouseClicked;
        Managers.Input.MouseAction += OnMouseClicked;
    }

    private float wait_run_ratio = 0;
    private void Update()
    {
        if (_moveToDest)
        {
            Vector3 dir = _destPos - transform.position;
            
            if (dir.magnitude < dirMinLength)
            {
                _moveToDest = false;
            }
            else
            {
                float moveDist = Mathf.Clamp(_speed * Time.deltaTime, 0, dir.magnitude);
                transform.position += dir.normalized * moveDist;
                
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 10 * Time.deltaTime);
                transform.LookAt(_destPos);
            }
        }

        if (_moveToDest)
        {
            wait_run_ratio = Mathf.Lerp(wait_run_ratio, 1 , 10.0f * Time.deltaTime);
            Animator anim = GetComponent<Animator>();
            anim.SetFloat("wait_run_ratio", wait_run_ratio);
            anim.Play("Wait_Run");
        }
        else
        {
            wait_run_ratio = Mathf.Lerp(wait_run_ratio, 0 , 10.0f * Time.deltaTime);
            Animator anim = GetComponent<Animator>();
            anim.SetFloat("wait_run_ratio", wait_run_ratio);
            anim.Play("Wait_Run");
        }
        
        
    }

    /// <summary>
    /// 키보드 이동
    /// </summary>
    private void OnKeyboard()
    {
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

        _moveToDest = false;
    }
    /// <summary>
    /// 마우스 이동
    /// </summary>
    private void OnMouseClicked(Define.MouseEvent evt)
    {
 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
        Debug.Log("Click");
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100.0f, LayerMask.GetMask("Wall")))
        { 
            _destPos = hit.point; 
            _moveToDest = true;
        }
    }
}


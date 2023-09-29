using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    
    private Vector3 _destPos;
    private float dirMinLength = 0.0001f;
    private void Start()
    {
        Managers.Input.MouseAction -= OnMouseClicked;
        Managers.Input.MouseAction += OnMouseClicked;
    }

    private float wait_run_ratio = 0;

    public enum PlayerState
    {
        Die,
        Moving,
        Idle,
    }

    private PlayerState _state = PlayerState.Idle;

    private void UpdateDie()
    {
        
    }
    private void UpdateMoving()
    {
        Vector3 dir = _destPos - transform.position;
            
        if (dir.magnitude < dirMinLength)
        {
            _state = PlayerState.Idle;
        }
        else
        {
            float moveDist = Mathf.Clamp(_speed * Time.deltaTime, 0, dir.magnitude);
            transform.position += dir.normalized * moveDist;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 10 * Time.deltaTime);
        }
        
        // 애니메이션

        Animator anim = GetComponent<Animator>();
        //현재 게임 상태에 대한 정보를 넘겨준다
        anim.SetFloat("speed", _speed);
        

    }

    private void OnRunEvent()
    {
        Debug.Log("와다다");
    }
    private void UpdateIdle()
    {
        // 애니메이션
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("speed", 0);

    }
    private void Update()
    {
        switch(_state)
        {
            case PlayerState.Die:
                UpdateDie();
                break;
            case PlayerState.Moving:
                UpdateMoving();
                break;
            case PlayerState.Idle:
                UpdateIdle();
                break;
        }
    }
    
    /// <summary>
    /// 마우스 이동
    /// </summary>
    private void OnMouseClicked(Define.MouseEvent evt)
    {
        if (_state == PlayerState.Die)
        {
            return;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100.0f, LayerMask.GetMask("Wall")))
        { 
            _destPos = hit.point; 
            _state = PlayerState.Moving;
        }
    }
}
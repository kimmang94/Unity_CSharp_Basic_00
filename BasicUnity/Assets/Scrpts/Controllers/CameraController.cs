using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Define.CameraMode _mode = Define.CameraMode.QuarterView;
    [SerializeField] private Vector3 _delta = new Vector3(0,6.0f, -5.0f);
    [SerializeField] private GameObject _player = null;
    
    

    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (_mode == Define.CameraMode.QuarterView)
        {
            transform.position = _player.transform.position + _delta;
            transform.LookAt(_player.transform);
        }
  
    }

    public void SetQuterView(Vector3 delta)
    {
        _mode = Define.CameraMode.QuarterView;
        _delta = delta;
    }
}

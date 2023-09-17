using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // GameObject(Player)
        // Transform
        // PlayerController
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0f, 0f);
        }
    }
}

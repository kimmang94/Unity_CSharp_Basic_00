using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;
    private GameObject tank;
    private void Start()
    {
        tank = Managers.Resource.Instantiate("Tank");

        Destroy(tank, 3.0f);
    }


}

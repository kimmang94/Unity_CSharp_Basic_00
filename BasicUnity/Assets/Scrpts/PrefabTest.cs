using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;
    private GameObject tank;
    private void Start()
    {
        prefab = Resources.Load< GameObject > ("Prefabs/Tank");
        tank = Instantiate(prefab);
        
        Destroy(tank, 4f);
    }


}

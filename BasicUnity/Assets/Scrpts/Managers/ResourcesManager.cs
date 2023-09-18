using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefeb = Load<GameObject>($"Prefabs/{path}");
        if (prefeb == null)
        {
            Debug.Log($"Failed to load Prefab : {path}");
            return null;
        }

        return Object.Instantiate(prefeb, parent);
    }

    public void Destroy(GameObject go)
    {
        if (go == null)
        {
            return;
        }

        Object.Destroy(go);
    }
}

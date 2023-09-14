using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance; // 유일성 보장
    public static Managers Instance // 유일한 매니저를 갖고온다
    { 
        get
        {
            Init(); return s_instance; 
        } 
    }

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        
    }

    /// <summary>
    /// 매니저 초기화 함수
    /// 매니저가 없으면 만들어서 갖고온다
    /// </summary>
    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("Managers");
            if (go == null)
            {
                go = new GameObject { name = "Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
       
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestTMP : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI tmpTExt = null;

    private int countNum = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpTExt.text = Convert.ToString(countNum);
    }

    public void OnButtonClicked()
    {
        countNum++;
        
    }
}

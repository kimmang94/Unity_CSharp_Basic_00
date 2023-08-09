using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button startBtn = null;
    [SerializeField] private Button optionsBtn = null;
    [SerializeField] private Button quitBtn = null;
    private void Awake()
    {
        startBtn.onClick.AddListener(OnClickGameStartBtn);
        optionsBtn.onClick.AddListener(OnClickOptionsBtn);
        quitBtn.onClick.AddListener(OnClickQuitBtn);        
    }

    private void OnClickGameStartBtn()
    {
        
    }
    private void OnClickOptionsBtn()
    {
        
    }
    
    private void OnClickQuitBtn()
    {
        Application.Quit();
    }
}

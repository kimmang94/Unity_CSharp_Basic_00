using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class UIManager : MonoBehaviour
{
    // IntroCanvas Btn
    [SerializeField] private Button startBtn = null;
    [SerializeField] private Button optionsBtn = null;
    [SerializeField] private Button quitBtn = null;
    
    [SerializeField] private GameObject optionPanel = null;
    // panel Btn
    [SerializeField] private Button agreeBtn = null;
    [SerializeField] private Button cancleBtn = null;
    private void Awake()
    {
        startBtn.onClick.AddListener(OnClickGameStartBtn);
        optionsBtn.onClick.AddListener(OnClickOptionsBtn);
        quitBtn.onClick.AddListener(OnClickQuitBtn);        
        agreeBtn.onClick.AddListener(OnAgreeBtn);
        cancleBtn.onClick.AddListener(OnCancleBtn);
    }

    private void OnClickGameStartBtn()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("LobbyScene");
    }
    private void OnClickOptionsBtn()
    {
        optionPanel.SetActive(true);
        Debug.Log("Options");
    }
    
    private void OnClickQuitBtn()
    {
        Debug.Log("App QUIT");
        Application.Quit();
    }

    private void OnCancleBtn()
    {
        optionPanel.SetActive(false);
    }

    private void OnAgreeBtn()
    {
        Debug.Log("옵션 데이터 저장");
    }

    private void OnClickBackBtn()
    {
        Debug.Log("BackBtn");
    }
}

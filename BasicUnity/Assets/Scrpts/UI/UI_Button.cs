using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{

    [SerializeField] private Text _text;

    private int score = 0;
    public void OnButtonClicked()
    {
        score++;
        _text.text = $"점수 : {score} 점";
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class UI_Button : UI_Base
{
    private int score = 0;
 
    private enum Buttons
    {
        PointButton,
        
    }
    private enum Texts
    {
        PointText,
        ScoreText,
        
    }

    private enum GameObject
    {
        TestObject,
        
    }
    
    private void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));
        Bind<UnityEngine.GameObject>(typeof(GameObject));

        GetText((int)Texts.ScoreText).text = "Bind Test";
    }

   
    public void OnButtonClicked()
    {
        score++;
    }
}

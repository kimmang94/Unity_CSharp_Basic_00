using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class UI_Button : UI_Base
{
   
 
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

    private enum Images
    { 
        ItemIcon,
    }
    
    private void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));
        Bind<UnityEngine.GameObject>(typeof(GameObject));
        Bind<Image>(typeof(Images));
        


        GetButton((int)Buttons.PointButton).gameObject.AddUIEvent(OnButtonClicked);
        
        UnityEngine.GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        AddUIEvent(go, (PointerEventData data) => { go.transform.position = data.position; },
            Define.UIEvent.Drag);

    }
    private int score = 0;
    public void OnButtonClicked(PointerEventData data)
    {
        score++;
        GetText((int)Texts.ScoreText).text = $"점수 : {score}";
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
        
        GetText((int)Texts.ScoreText).text = "Bind Test";
        UnityEngine.GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        UI_EvnetHandler evt = go.GetComponent<UI_EvnetHandler>();
        evt.OnDragHandler += ((PointerEventData data) => { evt.gameObject.transform.position = data.position; });
    }

   
    public void OnButtonClicked()
    {
        score++;
    }
}

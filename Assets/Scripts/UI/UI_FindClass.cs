using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_FindClass
{
    public GameObject UI_Canvas;
    public GameObject UI_BuildingWindow;

    public UI_FindClass() 
    {
        //UI_Canvas = GameObject.Find("UI_Canvas");
        UI_BuildingWindow = GameObject.Find("UI_BuildingWindow");
    }


}

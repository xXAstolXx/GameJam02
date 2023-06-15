using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_FindClass
{
    public GameObject UI_Canvas;
    public GameObject UI_BuildingWindow;

    public GameObject UI_ResourceTowerCanvas;
    public GameObject UI_WatchTowerCanvas;

    public UI_FindClass() 
    {
        //UI_Canvas = GameObject.Find("UI_Canvas");
        UI_BuildingWindow = GameObject.Find("UI_BuildingWindow");
        UI_ResourceTowerCanvas = GameObject.Find("ResourceTowerCanvas");
        UI_WatchTowerCanvas = GameObject.Find("WatchTowerCanvas");
    }


}

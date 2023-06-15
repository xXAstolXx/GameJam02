using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingWindow : UI_Window
{
    private Button towerBtn;
    private Button resBtn;

    private void Awake()
    {
        towerBtn = GameObject.Find("TowerButton").GetComponent<Button>();
        resBtn = GameObject.Find("ResourceButton").GetComponent<Button>();

        towerBtn.onClick.AddListener(BuildTower);
        resBtn.onClick.AddListener(BuildResource);
    }

    public void BuildResource()
    {
        calledBy.GetComponent<ColoredCells>().CreateResource();
        calledBy.GetComponent<ColoredCells>().SetField("Resource");
    }

    public void BuildTower()
    {
        calledBy.GetComponent<ColoredCells>().CreateTower();
    }
}

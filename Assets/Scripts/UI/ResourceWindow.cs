using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceWindow : UI_Window
{
    private Button resourceBtn;

    private void Awake()
    {
        resourceBtn = GameObject.Find("DestroyResTowerBtn").GetComponent<Button>();
        resourceBtn.onClick.AddListener(DestroyResourceTower);
    }

    public void DestroyResourceTower()
    {
        Debug.Log("Destroy");
    }

}

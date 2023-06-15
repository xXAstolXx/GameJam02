using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : Buildings
{
    [HideInInspector]
    public GameObject instantiatedBy;

    private UI_FindClass ui_FindClass;

    private void Awake()
    {
        ui_FindClass = new UI_FindClass();
        instantiatedBy.GetComponent<ColoredCells>().SetField("Resource");
    }

    public void OnClick()
    {
        Debug.Log("Keckse");
        ui_FindClass.UI_ResourceTowerCanvas.GetComponent<ResourceWindow>().SetVisibilty(true);
        ui_FindClass.UI_ResourceTowerCanvas.GetComponent<ResourceWindow>().SetPosition(transform.position + (Vector3.up * 5) + Vector3.right + Vector3.forward);
        ui_FindClass.UI_ResourceTowerCanvas.GetComponent<ResourceWindow>().SetCalledBy(gameObject);
    }
}

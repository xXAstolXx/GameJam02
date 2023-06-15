using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum MaterialColor
{
    RED = 0, 
    GREEN = 10, 
    BLUE = 20,
    GREY = 30,
    BLACK = 40
}
public class ColoredCells : MonoBehaviour
{
    [SerializeField]
    private GameObject tower;

    [SerializeField]
    private GameObject resource;


    [SerializeField]
    private Material[] materials;


    public MaterialColor materialColor;

    private UI_FindClass ui_FindClass;

    private string fieldState;

    private void Awake()
    {
        ui_FindClass = new UI_FindClass();

        SetField("Active");
    }

    private void ColorChangeOnAwake()
    {
        if (materialColor == MaterialColor.RED)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[0];

        }

        if (materialColor == MaterialColor.GREEN)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }

        if (materialColor == MaterialColor.BLUE)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[2];
        }

        if (materialColor == MaterialColor.GREY)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[3];
        }

        if (materialColor == MaterialColor.BLACK)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[4];
        }
    }

    public void SetField(string state)
    {
        fieldState = state;

        if (fieldState == "Active")
        {
            ColorChangeOnAwake();
        }

        if (fieldState == "Depleted")
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[3];
        }

        if (fieldState == "Disabled")
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[4];
        }

        if (fieldState == "Resource")
        {
            GetComponentInChildren<DepletionBar>().StartDepletion();
        }
    }

    public void OnClick()
    {
        if (fieldState == "Active")
        {
            Debug.Log(materialColor);
            ui_FindClass.UI_BuildingWindow.GetComponent<BuildingWindow>().SetVisibilty(true);
            ui_FindClass.UI_BuildingWindow.GetComponent<BuildingWindow>().SetPosition(transform.position + (Vector3.up * 5) + Vector3.right + Vector3.forward);
            ui_FindClass.UI_BuildingWindow.GetComponent<BuildingWindow>().SetCalledBy(gameObject);
        }
    }

    public void CreateResource()
    {
        Instantiate(resource, transform.position + (Vector3.up * 2), Quaternion.identity);
    }

    public void CreateTower()
    {
        Instantiate(tower, transform.position + (Vector3.up * 2), Quaternion.identity);
    }


}

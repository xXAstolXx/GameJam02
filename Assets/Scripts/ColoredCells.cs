using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum MaterialColor
{
    RED = 0, 
    GREEN = 10, 
    BLUE = 20
}
public class ColoredCells : MonoBehaviour
{
    [SerializeField]
    private Material[] materials;

    public MaterialColor materialColor;

    private UI_FindClass ui_FindClass;

    private void Awake()
    {
        ColorChangeOnAwake();
        ui_FindClass = new UI_FindClass();
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
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        Debug.Log(materialColor);
        ui_FindClass.UI_BuildingWindow.GetComponent<BuildingWindow>().SetVisibilty(true);
        ui_FindClass.UI_BuildingWindow.GetComponent<BuildingWindow>().SetPosition(transform.position + (Vector3.up * 5) + Vector3.right + Vector3.forward);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : Buildings
{
    [HideInInspector]
    public GameObject instantiatedBy;

    private void Awake()
    {
        instantiatedBy.GetComponent<ColoredCells>().SetField("Resource");
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceInventory : MonoBehaviour
{
    private int stoneAmount;
    private int waterAmount;
    private int woodAmount;

    private TextMeshProUGUI stone;
    private TextMeshProUGUI water;
    private TextMeshProUGUI wood;


    public void AddResource(string resource, int amount)
    {
        if(resource == "stone")
        {
            stoneAmount += amount;
        }

        if (resource == "water")
        {
            waterAmount += amount;
        }

        if (resource == "wood")
        {
            woodAmount += amount;
        }
    }

    public void RemoveResource(string resource, int amount) 
    {
        if(resource == "stone")
        { 
            stoneAmount -= amount;
        }

        if (resource == "water")
        {
            waterAmount -= amount;
        }

        if (resource == "wood")
        {
            woodAmount -= amount;
        }
    }
}

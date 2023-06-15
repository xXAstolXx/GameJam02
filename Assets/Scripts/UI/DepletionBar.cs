using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepletionBar : MonoBehaviour
{
    public void StartDepletion()
    {
        GetComponent<Animation>().Play();
    }

    public void OnDepleted()
    {
        GetComponentInParent<ColoredCells>().SetField("Depleted");
    }
}

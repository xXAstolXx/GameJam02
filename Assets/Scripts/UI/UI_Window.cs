using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window : MonoBehaviour
{


    public void ToggleVisibilty()
    {
        GetComponent<Canvas>().enabled = !GetComponent<Canvas>().enabled;
    }

    public void SetVisibilty(bool value)
    {
        GetComponent<Canvas>().enabled = value;
    }

    public void SetPosition(Vector3 pos)
    {
        transform.position = pos;
    }
}

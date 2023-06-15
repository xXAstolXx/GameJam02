using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window : MonoBehaviour
{
    public GameObject calledBy;

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

    public void SetCalledBy(GameObject obj)
    {
        calledBy = obj;
    }

}

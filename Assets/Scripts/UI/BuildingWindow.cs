using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleVisibilty()
    {
        GetComponent<Canvas>().enabled = !GetComponent<Canvas>().enabled;
    }

    public void SetVisibilty(bool value)
    {
        GetComponent<Canvas>().enabled = value;
    }
}

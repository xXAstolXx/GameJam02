using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Color
{
    RED, GREEN, BLUE
}
public class ColoredCells : MonoBehaviour
{
    [SerializeField]
    private Material[] materials;

    [SerializeField]
    private Color[] colors;

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
        Debug.Log("Hit");
    }
}

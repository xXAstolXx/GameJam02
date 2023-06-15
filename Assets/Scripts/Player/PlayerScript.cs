using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    private Camera m_camera;
    private MouseBindings mouseBinds;
    private InputAction leftclick;
    private InputAction rightclick;
    private InputAction mousePos;


    private void Awake()
    {
        m_camera = Camera.main;
        mouseBinds = new MouseBindings();
        leftclick =  mouseBinds.Mouse.LeftClick;
        rightclick = mouseBinds.Mouse.RightClick;
        mousePos = mouseBinds.Mouse.MousePos;

    }

    private void OnEnable()
    {
        leftclick.Enable();
        rightclick.Enable();
        mousePos.Enable();

    }
    private void OnDisable()
    {
        leftclick.Disable();
        rightclick.Disable();
        mousePos.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if(leftclick.WasPerformedThisFrame() == true)
        {
            Vector2 mousePosition2D = mousePos.ReadValue<Vector2>();

            Ray ray = m_camera.ScreenPointToRay(mousePosition2D);
            RaycastHit hit;

            Debug.Log("SHOOT");
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null)
                {
                    hit.collider.GetComponent<ColoredCells>().OnClick();
                }
            }
        }
    }
}

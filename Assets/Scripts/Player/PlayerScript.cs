using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    private Camera m_camera;
    private MouseBindings mouseBinds;
    private InputAction leftclick;
    private InputAction rightclick;
    private InputAction mousePos;

    private UI_FindClass ui_FindClass;


    private void Awake()
    {
        ui_FindClass = new UI_FindClass();
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
                if(hit.collider == null)
                {
                    Debug.Log("Miss");
                }

                if(hit.collider.GetComponent<ColoredCells>() != null)
                {
                    hit.collider.GetComponent<ColoredCells>().OnClick();

                }
            }

        }

        if (rightclick.WasPerformedThisFrame() == true)
        {
            ui_FindClass.UI_BuildingWindow.GetComponent<UI_Window>().SetVisibilty(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControlls : MonoBehaviour
{

    [SerializeField]
    private float speed = 3.0f;
    private KeyboardBindings keybinds;
    private InputAction wKey;
    private InputAction aKey;
    private InputAction sKey;
    private InputAction dKey;


    private void Awake()
    {
        keybinds = new KeyboardBindings();
        wKey = keybinds.Keyboard.W;
        aKey = keybinds.Keyboard.A;
        sKey = keybinds.Keyboard.S;
        dKey = keybinds.Keyboard.D;
    }
    private void OnEnable()
    {
        wKey.Enable();
        aKey.Enable();
        sKey.Enable();
        dKey.Enable();
    }
    private void OnDisable()
    {
        wKey.Disable();
        aKey.Disable();
        sKey.Disable();
        dKey.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if(wKey.IsPressed() == true)
        {
            gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (aKey.IsPressed() == true)
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (sKey.IsPressed() == true)
        {
            gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (dKey.IsPressed() == true)
        {
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }
}

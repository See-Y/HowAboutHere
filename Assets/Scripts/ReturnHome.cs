using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReturnHome : MonoBehaviour
{
    public InputActionReference HomeReference = null;
    public Canvas menu;
    private Vector3 init_position;

    private Quaternion init_rotation;
    // Start is called before the first frame update
    private void Awake()
    {
        HomeReference.action.started += OnHome;
        HomeReference.action.started += OnMenu;
    }

    private void OnDestroy()
    {
        HomeReference.action.started -= OnHome;
        HomeReference.action.started -= OnMenu;
    }

    void Start()
    {
        init_position = transform.position;
        init_rotation = transform.rotation;
    }

    public void OnHome(InputAction.CallbackContext context)
    {
        if(!context.performed)
        {
            
            transform.position = init_position;
            transform.rotation = init_rotation;
        }
    }

    public void OnMenu(InputAction.CallbackContext context)
    {
        if (!context.performed)
        {
            
        }
        else
        {
            
        }
    }
}

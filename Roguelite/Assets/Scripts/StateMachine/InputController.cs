using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActionAsset;
    private void OnEnable()
    {
        inputActionAsset.Enable();
    }

    public Vector2 GetMousePosition()
    {
        Vector2 mousePos = inputActionAsset.FindAction("MousePosition").ReadValue<Vector2>();
        return mousePos;
    }
    
    public void AddBehaviourToKey(KeyCode key, Action method)
    {
        Debug.Log("Key: " + key.ToString());
        inputActionAsset.FindAction(key.ToString()).performed += ctx => method.Invoke();
    }

    private void OnDisable()
    {
        inputActionAsset.Disable();
    }

}

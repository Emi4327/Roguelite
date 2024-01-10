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
    private void OnDisable()
    {
        inputActionAsset.Disable();
    }
}

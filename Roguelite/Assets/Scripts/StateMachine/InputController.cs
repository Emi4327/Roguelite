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

    private void OnDisable()
    {
        inputActionAsset.Disable();
    }
}
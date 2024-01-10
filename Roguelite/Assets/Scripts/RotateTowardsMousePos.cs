using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsMousePos : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private InputController inputController;
    [SerializeField] private float rotationOffset = -90;
    void Update()
    {
        Vector3 mousePosition = playerCamera.ScreenToWorldPoint(inputController.GetMousePosition());
        mousePosition.z = 0f;

        Vector3 direction = mousePosition - transform.position;
        direction.Normalize();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle+rotationOffset));
    }
}

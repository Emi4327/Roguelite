using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private List<InventorySlot> slots = new List<InventorySlot>();
    private int currentActiveSlot;
    private InputController inputController;
    private void Awake()
    {
        ChangeActiveSlot(0);
        inputController = GameManager.Instance.player.GetComponent<InputController>();
        inputController.AddBehaviourToKey(KeyCode.Alpha1, KeyOneFunctionality);
        inputController.AddBehaviourToKey(KeyCode.Alpha2, KeyTwoFunctionality);
    }
    
    private void KeyOneFunctionality()
    {
        ChangeActiveSlot(0);
    }
    private void KeyTwoFunctionality()
    {
        ChangeActiveSlot(1);
    }
    private void ChangeActiveSlot(int slot)
    {
        slots[currentActiveSlot].DeactivateSlot();
        slots[slot].ActivateSlot();
        currentActiveSlot = slot;
    }
}

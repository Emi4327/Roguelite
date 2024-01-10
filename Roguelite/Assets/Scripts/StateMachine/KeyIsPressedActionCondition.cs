using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIsPressedActionCondition : IStateActionCondition
{
    private ActionsEnum keyToCheck;
    public KeyIsPressedActionCondition(ActionsEnum key)
    {
        keyToCheck = key;
    }
    public bool CheckCondition(StateMachine machine)
    {
        PlayerStateMachine playerMachine = machine as PlayerStateMachine;
        var inputActionAsset = playerMachine.InputActionAsset;

        var action = inputActionAsset.FindAction(keyToCheck.ToString());

        if(action == null) return false;
        return action.triggered;
    }
}

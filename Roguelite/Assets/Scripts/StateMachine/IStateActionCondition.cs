using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateActionCondition
{
    public bool CheckCondition(StateMachine machine) { return false; }
}

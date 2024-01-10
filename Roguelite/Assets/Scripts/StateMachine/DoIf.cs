using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoIf : StateAction
{
    private List<IStateActionCondition> conditions;
    private StateAction action;

    public DoIf(List<IStateActionCondition> conditions, StateAction action)
    {
        this.conditions = conditions;
        this.action = action;
    }

    public override void Do(StateMachine machine)
    {
        foreach(var condition in conditions)
        {
            if(!condition.CheckCondition(machine)) return;
        }
        action.Do(machine);
    }
}

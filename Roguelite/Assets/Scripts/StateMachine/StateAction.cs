using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateAction
{
    public virtual void Initialize(StateMachine machine) { }
    public virtual void Do(StateMachine machine) { }
    public virtual void DoInFixedUpdate(StateMachine machine) { }

}

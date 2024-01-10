using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void Initialize(StateMachine machine) { }
    public void OnStateEnter() { }
    public void OnStateUpdate() { }
    public void OnStateFixedUpdate() { }
    public void OnStateExit() { }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : IState
{
    private List<StateAction> actions = new List<StateAction>();
    private StateMachine machine;
    public PlayerMoveState(StateMachine machine)
    {
        Initialize(machine);
    }
    public void Initialize(StateMachine machine)
    {
        this.machine = machine;
        actions.Add(new PlayerMoveAction(machine));
        actions.Add(new RotateTowardsMousePosAction(machine));
    }
    public void OnStateEnter()
    {
        foreach(var action in actions)
        {
            action.Do(machine);
        }
    }
    public void OnStateUpdate()
    {
        foreach(var action in actions)
        {
            action.Do(machine);
        }
    }
    public void OnStateFixedUpdate()
    {
        foreach(var action in actions)
        {
            action.DoInFixedUpdate(machine);
        }
    }
}

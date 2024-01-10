using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private List<IState> states = new List<IState>();
    private IState currentState;
    private IState previousState;
    private Dictionary<Type, Component> parentComponents = new Dictionary<Type, Component>();
    private void Start()
    {
        InitializeComponentsDict<Component>();
        InitializeFirstState(new PlayerMoveState(this));

    }

    private void Update()
    {
        currentState.OnStateUpdate();
    }
    private void FixedUpdate()
    {
        currentState.OnStateFixedUpdate();
    }
    public void ChangeState(IState nextState)
    {
        currentState.OnStateExit();
        previousState = currentState;
        currentState = nextState;
        currentState.OnStateEnter();
    }
    public Component GetParentComp<T>() where T : Component
    {
        return parentComponents[typeof(T)];

    }
    private void InitializeFirstState(IState state)
    {
        currentState = state;
        currentState.OnStateEnter();
    }
    private void InitializeComponentsDict<T>() where T : Component
    {
        Component[] allMyComponents = GetComponents<T>();

        foreach(var item in allMyComponents)
        {
            parentComponents.Add(item.GetType(), item);
        }
    }

}

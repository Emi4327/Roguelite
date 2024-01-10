using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateTowardsMousePosAction : StateAction
{
    private InputController inputController;


    public RotateTowardsMousePosAction(StateMachine machine)
    {
        Initialize(machine);
    }

    public override void Initialize(StateMachine machine)
    {
       inputController = machine.GetParentComp<InputController>() as InputController;
    }
    public override void Do(StateMachine machine)
    {
        Rotate(machine);
    }
    private void Rotate(StateMachine machine)
    {
        if(machine.transform.localScale.x > 0 && inputController.GetMousePosition().x < Screen.width / 2)
        {
            ChangeDirection(machine);
        }
        else if(machine.transform.localScale.x < 0 && inputController.GetMousePosition().x > Screen.width / 2)
        {
            ChangeDirection(machine);
        }
    }
    private void ChangeDirection(StateMachine machine)
    {
        machine.transform.localScale = new Vector3(-machine.transform.localScale.x, machine.transform.localScale.y, machine.transform.localScale.z);
    }
}

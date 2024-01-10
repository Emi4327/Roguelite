using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveAction : StateAction
{
    private InputAction inputAction;
    private StateMachine machine;

    public PlayerMoveAction(StateMachine machine)
    {
        Initialize(machine);
    }

    public override void Initialize(StateMachine machine)
    {
        PlayerStateMachine playerMachine = machine as PlayerStateMachine;
        inputAction = playerMachine.InputActionAsset.FindAction("Move");
        this.machine = machine;
    }
    public override void Do(StateMachine machine)
    {
        Move();
    }
    private void Move()
    {
        Vector2 movementInput = inputAction.ReadValue<Vector2>();
        Rigidbody2D rb = machine.GetParentComp<Rigidbody2D>() as Rigidbody2D;
        rb.velocity = movementInput.normalized * (machine as PlayerStateMachine).PlayerStats.Speed;
    }
}

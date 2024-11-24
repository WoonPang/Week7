using Unity.VisualScripting;
using UnityEngine;

public class IdleState : IState
{
    private PlayerController player;

    // pass in any parameters you need in the constructors
    public IdleState(PlayerController player) {  this.player = player; }

    // per-frame logic, include condition to transition to a new state
    public void Update()
    {
        if (!player.IsGrounded)
        {
            player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.jumpState);
        }

        // if we move above a minimum threshold, transition to walking
        if (Mathf.Abs(player.CharController.velocity.x) > 0.1f ||
            Mathf.Abs(player.CharController.velocity.z) > 0.1f)
        {
            player.PlayerStateMachine.TransitionTo
                (player.PlayerStateMachine.walkState);
        }
    }

}

using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.PlayerStateFolder
{
    public class IdleState : State<PlayStateMachine>
    {
        public override void Enter()
        {
            stateMachine.Context.PlayStateType = PlayStateType.Idle;

            Debug.Log("进入闲置状态");
        }

        public override void Update()
        {
            if (stateMachine.Context.MoveInputAction.IsPressed())
            {
                stateMachine.ChangeState<MoveState>();
            }

            if (stateMachine.Context.AttackInputAction.IsPressed())
            {
                stateMachine.ChangeState<AttackState>();
            }
        }

        public override void FixedUpdate()
        {

        }

        public override void Exit()
        {
            Debug.Log("离开闲置状态");
        }
    }
}
using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.PlayerStateFolder
{
    public class MoveState : State<PlayStateMachine>
    {
        public override void Enter()
        {
            stateMachine.Context.PlayStateType = PlayStateType.Move;

            Debug.Log("进入移动状态");
        }

        public override void Update()
        {
            if (!stateMachine.Context.MoveInputAction.IsInProgress())
            {
                stateMachine.ChangeState<IdleState>();
            }
        }

        public override void FixedUpdate()
        {

        }

        public override void Exit()
        {
            Debug.Log("离开移动状态");
        }
    }
}
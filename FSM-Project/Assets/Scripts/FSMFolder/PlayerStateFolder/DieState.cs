using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.PlayerStateFolder
{
    public class DieState : State<PlayStateMachine>
    {
        public override void Enter()
        {
            int attackCount = stateMachine.Context.AttackCount;
            stateMachine.Context.PlayStateType = PlayStateType.Die;

            Debug.Log($"进入死亡状态: {attackCount}");
        }

        public override void Update()
        {
            if (stateMachine.Context.RestartPlayInputAction.IsPressed())
            {
                stateMachine.ChangeState<IdleState>();
            }
        }

        public override void FixedUpdate()
        {

        }

        public override void Exit()
        {
            Debug.Log("离开死亡状态");
            stateMachine.Context.Hp = 100;
        }
    }
}
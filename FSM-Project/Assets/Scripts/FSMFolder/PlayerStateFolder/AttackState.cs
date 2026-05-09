using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.PlayerStateFolder
{
    public class AttackState : State<PlayStateMachine>
    {
        private float _attackTime = 0;

        public override void Enter()
        {
            int attackCount = ++stateMachine.Context.AttackCount;
            stateMachine.Context.PlayStateType = PlayStateType.Attack;

            Debug.Log($"进入攻击状态: {attackCount}");
        }

        public override void Update()
        {
            _attackTime += Time.deltaTime;

            if (_attackTime > stateMachine.Context.AttackLoadTime)
            {
                stateMachine.ChangeState<IdleState>();
                _attackTime = 0;
            }
        }

        public override void FixedUpdate()
        {

        }

        public override void Exit()
        {
            Debug.Log("离开攻击状态");
        }
    }
}
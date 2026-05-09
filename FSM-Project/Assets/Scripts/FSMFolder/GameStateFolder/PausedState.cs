using FSMFolder.Entity;
using FSMFolder.PlayerStateFolder;
using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.GameStateFolder
{
    // 暂停状态
    public class PausedState : State<GameStateMachine>
    {
        private float _pausedTime;
        private float _pausedLoadTime = 0.5f;

        public override void Enter()
        {
            Time.timeScale = 0;
            stateMachine.Context.IsPaused = true;
            stateMachine.Context.GameStateType = GameStateType.Paused;

            Debug.Log("进入暂停状态");
        }

        public override void Update()
        {
            _pausedTime += Time.deltaTime;

            if (_pausedTime > _pausedLoadTime)
            {
                stateMachine.ChangeState<PlayingState>();
                _pausedTime = 0;
            }
        }

        public override void FixedUpdate() { }

        public override void Exit()
        {
            Debug.Log("退出暂停状态");
            Time.timeScale = 1;
            stateMachine.Context.IsPaused = false;
        }
    }
}
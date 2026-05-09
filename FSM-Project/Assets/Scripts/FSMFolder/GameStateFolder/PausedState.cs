using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.GameStateFolder
{
    // 暂停状态
    public class PausedState : State<GameStateMachine>
    {
        public override void Enter()
        {
            Debug.Log("进入暂停状态");
            Time.timeScale = 0;
            stateMachine.Context.IsPaused = true;
        }

        public override void Update()
        {
            if (stateMachine.Context.PausedInputAction.IsPressed())
            {
                stateMachine.ChangeState<PlayingState>();
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
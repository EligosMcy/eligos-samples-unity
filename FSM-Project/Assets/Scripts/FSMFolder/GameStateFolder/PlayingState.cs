using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.GameStateFolder
{
    // 游戏进行状态
    public class PlayingState : State<GameStateMachine>
    {
        public override void Enter()
        {
            stateMachine.Context.GameStateType = GameStateType.Playing;

            Debug.Log("进入游戏状态");

            PlayManager.Instance.StartPlay();
        }

        public override void Update()
        {
            if (stateMachine.Context.PausedInputAction.IsPressed())
            {
                stateMachine.ChangeState<PausedState>();
            }

            if (stateMachine.Context.DeductLivesAction.triggered)
            {
                stateMachine.Context.Lives -= 10;
                Debug.Log($"扣除生命： {stateMachine.Context.Lives}");
            }

            if (stateMachine.Context.Lives <= 0)
            {
                stateMachine.ChangeState<GameOverState>();
            }
        }

        public override void FixedUpdate()
        {
            // PlayManager.Instance.UpdateGame();
        }

        public override void Exit()
        {
            PlayManager.Instance.StopPlay();
            Debug.Log("退出游戏状态");
        }
    }
}
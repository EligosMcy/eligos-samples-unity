using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.GameStateFolder
{
    // 游戏进行状态
    public class PlayingState : State<GameStateMachine>
    {
        public override void Enter()
        {
            Debug.Log("进入游戏状态");
            // GameManager.Instance.StartGame();
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
            // GameManager.Instance.UpdateGame();
        }

        public override void Exit()
        {
            Debug.Log("退出游戏状态");
        }
    }
}
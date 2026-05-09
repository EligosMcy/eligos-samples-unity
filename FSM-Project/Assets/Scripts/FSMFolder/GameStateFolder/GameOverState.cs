using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.GameStateFolder
{
    // 游戏结束状态
    public class GameOverState : State<GameStateMachine>
    {
        public override void Enter()
        {
            stateMachine.Context.Score++;
            stateMachine.Context.Lives = 100;
            int score = stateMachine.Context.Score;
            int lives = stateMachine.Context.Lives;

            Debug.Log($"进入游戏结束状态: {score} , {lives}");

            // UIManager.Instance.ShowGameOver();
        }

        public override void Update()
        {
            if (stateMachine.Context.RestartGameAction.IsPressed())
            {
                stateMachine.ChangeState<MenuState>();
            }
        }

        public override void FixedUpdate() { }

        public override void Exit()
        {
            Debug.Log("退出游戏结束状态");
        }
    }
}
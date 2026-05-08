using FSMFolder.StateBaseFolder;
using UnityEditor;
using UnityEngine;

namespace FSMFolder.StateFolder
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
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                stateMachine.ChangeState<PausedState>();
            }

            if (stateMachine.Context.lives <= 0)
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
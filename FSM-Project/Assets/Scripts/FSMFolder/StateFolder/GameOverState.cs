using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.StateFolder
{
    // 游戏结束状态
    public class GameOverState : State<GameStateMachine>
    {
        public override void Enter()
        {
            Debug.Log("进入游戏结束状态");
            // UIManager.Instance.ShowGameOver();
        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
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
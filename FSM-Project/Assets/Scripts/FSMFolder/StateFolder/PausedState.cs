using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.StateFolder
{
    // 暂停状态
    public class PausedState : State<GameStateMachine>
    {
        public override void Enter()
        {
            Debug.Log("进入暂停状态");
            Time.timeScale = 0;
            // UIManager.Instance.ShowPauseMenu();
        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                stateMachine.ChangeState<PlayingState>();
            }
        }

        public override void FixedUpdate() { }

        public override void Exit()
        {
            Debug.Log("退出暂停状态");
            Time.timeScale = 1;
            // UIManager.Instance.HidePauseMenu();
        }
    }
}
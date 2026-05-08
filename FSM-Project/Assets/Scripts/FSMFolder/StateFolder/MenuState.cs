using FSMFolder.StateBaseFolder;
using UnityEngine;
using FSMFolder.Entity;

namespace FSMFolder.StateFolder
{
    // 菜单状态
    public class MenuState : State<GameStateMachine>
    {
        public override void Enter()
        {
            Debug.Log("进入菜单状态");
            // UIManager.Instance.ShowMenu();
        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                stateMachine.ChangeState<PlayingState>();
            }
        }

        public override void FixedUpdate() { }

        public override void Exit()
        {
            Debug.Log("退出菜单状态");
            // UIManager.Instance.HideMenu();
        }
    }
}
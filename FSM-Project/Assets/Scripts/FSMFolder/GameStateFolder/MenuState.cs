using FSMFolder.StateBaseFolder;
using UnityEngine;

namespace FSMFolder.GameStateFolder
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
            if (stateMachine.Context.PlayInputAction.IsPressed())
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
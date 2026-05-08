using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine.InputSystem;

namespace FSMFolder.StateFolder
{
    public class GameStateMachine : StateMachine<GameStateMachine>
    {
        public GameContext Context { get; private set; }

        public GameStateMachine(InputAction inputAction)
        {
            Context = new GameContext();
            // 初始状态
            ChangeState<MenuState>();
        }

        public override void Update()
        {
            base.Update();
            // 可以在这里添加全局状态逻辑
        }
    }
}
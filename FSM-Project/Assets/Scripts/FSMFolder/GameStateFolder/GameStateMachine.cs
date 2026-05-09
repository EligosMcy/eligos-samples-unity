using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine.InputSystem;

namespace FSMFolder.GameStateFolder
{
    public class GameStateMachine : StateMachine<GameStateMachine>
    {
        public GameContext Context { get; private set; }

        public GameStateMachine(InputActionAsset inputActionAsset)
        {
            InputActionMap inputActionMap = inputActionAsset.FindActionMap("FSM");

            InputAction playInputAction = inputActionMap.FindAction("PlayAction");
            InputAction pausedInputAction = inputActionMap.FindAction("PausedAction");
            InputAction deductLivesAction = inputActionMap.FindAction("DeductLivesAction");
            InputAction restartGameAction = inputActionMap.FindAction("RestartGameAction");

            inputActionMap.Enable();

            Context = new GameContext
            {
                Score = 0,
                Lives = 100,
                IsPaused = false,
                InputActionAsset = inputActionAsset,
                InputActionMap = inputActionMap,
                PlayInputAction = playInputAction,
                PausedInputAction = pausedInputAction,
                DeductLivesAction = deductLivesAction,
                RestartGameAction = restartGameAction,
            };

            // 初始状态
            ChangeState<MenuState>();
        }

        public override void Update()
        {
            base.Update();
            // 可以在这里添加全局状态逻辑
        }


        public override void FixedUpdate()
        {
            base.FixedUpdate();
            // 可以在这里添加全局状态逻辑
        }
    }
}
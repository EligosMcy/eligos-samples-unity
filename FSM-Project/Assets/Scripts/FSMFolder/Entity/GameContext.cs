using UnityEngine.InputSystem;

namespace FSMFolder.Entity
{
    // 游戏状态机上下文
    public class GameContext
    {
        public int Score;
        public int Lives;
        public bool IsPaused;

        public GameStateType GameStateType;

        public InputActionAsset InputActionAsset;

        public InputActionMap InputActionMap;

        public InputAction PlayInputAction;

        public InputAction PausedInputAction;

        public InputAction DeductLivesAction;

        public InputAction RestartGameAction;
        // ... 其他游戏数据
    }

    public class PlayContext
    {
        public int AttackCount;

        public int Hp;

        //
        public float AttackLoadTime = 0.5f;

        public PlayStateType PlayStateType;

        //
        public InputActionAsset InputActionAsset;

        public InputActionMap InputActionMap;

        public InputAction MoveInputAction;

        public InputAction AttackInputAction;

        public InputAction DeductHpInputAction;

        public InputAction RestartPlayInputAction;
    }

}
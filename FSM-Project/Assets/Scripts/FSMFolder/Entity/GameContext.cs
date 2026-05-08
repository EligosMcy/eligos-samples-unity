using UnityEngine.InputSystem;

namespace FSMFolder.Entity
{
    // 游戏状态机上下文
    public class GameContext
    {
        public int score;
        public int lives;
        public bool isPaused;

        public InputAction InputAction;
        // ... 其他游戏数据
    }

}
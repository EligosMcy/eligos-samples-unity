namespace FSMFolder.Entity
{
    // 游戏状态枚举
    public enum GameStateType
    {
        Menu,
        Playing,
        Paused,
        GameOver
    }


    // 玩家状态枚举
    public enum PlayStateType
    {
        Idle,
        Move,
        Attack,
        Die
    }
}

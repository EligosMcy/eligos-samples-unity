namespace FSMFolder.StateBaseFolder
{
    public abstract class State<T> where T : StateMachine<T>
    {
        protected T stateMachine;

        public void Initialize(T machine)
        {
            stateMachine = machine;
        }

        // 进入状态时调用
        public abstract void Enter();

        // 每帧更新时调用
        public abstract void Update();

        // 物理更新时调用
        public abstract void FixedUpdate();

        // 退出状态时调用
        public abstract void Exit();
    }
}

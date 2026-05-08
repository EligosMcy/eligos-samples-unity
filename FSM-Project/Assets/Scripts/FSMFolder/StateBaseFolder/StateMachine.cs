using System;
using System.Collections.Generic;

namespace FSMFolder.StateBaseFolder
{
    public abstract class StateMachine<T> where T : StateMachine<T>
    {
        public State<T> CurrentState { get; private set; }
        public State<T> PreviousState { get; private set; }

        // 状态字典
        protected Dictionary<Type, State<T>> states = new Dictionary<Type, State<T>>();

        // 状态切换
        public void ChangeState<TS>() where TS : State<T>
        {
            Type targetType = typeof(TS);

            if (!states.ContainsKey(targetType))
            {
                // 动态创建状态实例
                State<T> newState = Activator.CreateInstance<TS>();
                newState.Initialize((T)this);
                states[targetType] = newState;
            }

            if (CurrentState != null)
            {
                CurrentState.Exit();
                PreviousState = CurrentState;
            }

            CurrentState = states[targetType];
            CurrentState.Enter();
        }

        // 返回上一个状态
        public void RevertToPreviousState()
        {
            if (PreviousState != null)
            {
                // ChangeState(PreviousState.GetType());
            }
        }

        // 状态机更新
        public virtual void Update()
        {
            CurrentState?.Update();
        }

        public virtual void FixedUpdate()
        {
            CurrentState?.FixedUpdate();
        }
    }
}
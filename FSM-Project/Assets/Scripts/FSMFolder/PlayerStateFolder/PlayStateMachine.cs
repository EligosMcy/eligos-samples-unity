using FSMFolder.Entity;
using FSMFolder.StateBaseFolder;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FSMFolder.PlayerStateFolder
{
    public class PlayStateMachine : StateMachine<PlayStateMachine>
    {
        public PlayContext Context { get; private set; }

        public PlayStateMachine(InputActionAsset inputActionAsset)
        {
            InputActionMap inputActionMap = inputActionAsset.FindActionMap("Play");

            InputAction moveInputAction = inputActionMap.FindAction("MoveInputAction");

            InputAction attackInputAction = inputActionMap.FindAction("AttackInputAction");

            InputAction deductHpInputAction = inputActionMap.FindAction("DeductHpInputAction");

            InputAction restartPlayInputAction = inputActionMap.FindAction("RestartPlayInputAction");

            Context = new PlayContext()
            {
                AttackCount = 0,
                Hp = 100,
                AttackLoadTime = 0.5f,
                InputActionAsset = inputActionAsset,
                InputActionMap = inputActionMap,
                MoveInputAction = moveInputAction,
                AttackInputAction = attackInputAction,
                DeductHpInputAction = deductHpInputAction,
                RestartPlayInputAction = restartPlayInputAction,
            };

            ChangeState<IdleState>();
        }

        public override void Update()
        {
            base.Update();

            if (Context.PlayStateType != PlayStateType.Die)
            {
                if (Context.Hp <= 0)
                {
                    ChangeState<DieState>();
                }

                if (Context.DeductHpInputAction.triggered)
                {
                    Context.Hp -= 10;
                    Debug.Log($"扣除生命： {Context.Hp}");
                }
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

        }
    }
}
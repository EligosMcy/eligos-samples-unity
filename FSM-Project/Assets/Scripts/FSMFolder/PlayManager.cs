using System;
using FSMFolder.PlayerStateFolder;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FSMFolder
{
    public class PlayManager : MonoBehaviour
    {
        public static PlayManager Instance;

        private PlayStateMachine _playStateMachine;

        [SerializeField] private InputActionAsset _inputActionAsset;

        private void Awake()
        {
            Instance = this;
            _playStateMachine = new PlayStateMachine(_inputActionAsset);
        }


        //通过开关Map实现玩家控制功能的启动和关闭
        public void StartPlay()
        {
            _playStateMachine.Context.InputActionMap.Enable();
        }

        public void StopPlay()
        {
            _playStateMachine.Context.InputActionMap.Disable();
        }

        private void Update()
        {
            _playStateMachine.Update();
        }

        private void FixedUpdate()
        {
            _playStateMachine.FixedUpdate();
        }
    }
}
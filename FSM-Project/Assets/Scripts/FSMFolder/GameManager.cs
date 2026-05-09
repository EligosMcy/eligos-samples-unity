using System;
using FSMFolder.PlayerStateFolder;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FSMFolder
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        private PlayStateMachine _playStateMachine;

        [SerializeField] private InputActionAsset _inputActionAsset;

        private void Awake()
        {
            Instance = this;
            _playStateMachine = new PlayStateMachine(_inputActionAsset);
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
using System;
using FSMFolder.StateFolder;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FSMFolder
{
    public class FSMManager : MonoBehaviour
    {
        public static FSMManager Instance;

        [SerializeField] 
        private InputAction _inputAction;

        private GameStateMachine _gameStateMachine;

        private void Awake()
        {
            Instance = this;
            _gameStateMachine = new GameStateMachine(_inputAction);
        }

        private void Update()
        {
            _gameStateMachine.Update();
        }

        private void FixedUpdate()
        {
            _gameStateMachine.FixedUpdate();
        }
    }
}
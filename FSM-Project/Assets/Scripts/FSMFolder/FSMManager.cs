using System;
using FSMFolder.GameStateFolder;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FSMFolder
{
    public class FSMManager : MonoBehaviour
    {
        public static FSMManager Instance;

        [SerializeField] 
        private InputActionAsset _inputActionAsset;

        private GameStateMachine _gameStateMachine;

        private void Awake()
        {
            Instance = this;
            _gameStateMachine = new GameStateMachine(_inputActionAsset);
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
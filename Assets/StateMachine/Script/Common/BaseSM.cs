using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine {

    public abstract class BaseSM : MonoBehaviour {

        protected BaseState CurrentState {
            get { return _currentState; }
            set {
                if (_currentState != null)
                    _currentState.Exit();
                _currentState = value;
                if (_currentState != null)
                    _currentState.Enter();
            }
        }
        private BaseState _currentState;

        public abstract void StartSM();

        public void StopSM() {
            CurrentState = null;
        }

        private void Update() {
            if (CurrentState != null)
                CurrentState.Tick();
        }

    }

}

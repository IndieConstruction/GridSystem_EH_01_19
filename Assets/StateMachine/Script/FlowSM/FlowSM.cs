using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine {

    public class FlowSM : MonoBehaviour {

        public GlobalUI UIReference;

        protected BaseState CurrentState {
            get { return _currentState; }
            set {
                if(_currentState != null)
                    _currentState.Exit();
                _currentState = value;
                if (_currentState != null)
                    _currentState.Enter();
            }
        }
        private BaseState _currentState;

        BaseState.Context newContext;

        private void Start() {
            // Solo per test
            StartSM();
        }

        public void StartSM() {
            // Inizializzo il contest condiviso tra tutti gli stati
            newContext = new BaseState.Context() {
                IntroCountdown = 3.3f,                  // durata della splash intro
                UI = UIReference,                       // GlobalUI
                OnStateEnding = onStateEndingCallback,  // Callback generica
            };
            // Creo lo stato iniziale, lo setuppo e lo assegno
            BaseState newState = new FL_SplashScreen_State();
            newState.Setup(newContext);
            CurrentState = newState;
        }

        public void StopSM() {
            CurrentState = null;
        }

        protected void goToMainMenu() {
            BaseState newState = new FL_MainMenu_State();
            newState.Setup(newContext);
            CurrentState = newState;
        }

        private void Update() {
            if (CurrentState != null)
                CurrentState.Tick();

            #region TESTS
            if (Input.GetKeyDown(KeyCode.Space)) {
                goToMainMenu();
            }
            #endregion

        }

        #region Events

        private void onStateEndingCallback() {
            goToMainMenu();
        }

        #endregion

    }

}

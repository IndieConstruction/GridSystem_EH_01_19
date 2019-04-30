using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine {

    public class FlowSM : BaseSM {

        public GlobalUI UIReference;

        BaseState.Context newContext;

        private void Start() {
            // Solo per test
            StartSM();
        }

        public override void StartSM() {
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

        #region routing

        protected void goToMainMenu() {
            BaseState newState = new FL_MainMenu_State();
            newState.Setup(newContext);
            CurrentState = newState;
        }

        #endregion

        #region Events

        private void onStateEndingCallback() {
            goToMainMenu();
        }

        #endregion

    }

}

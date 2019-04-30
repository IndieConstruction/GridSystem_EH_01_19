using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace StateMachine {

    /// <summary>
    /// Classe base per ogni stato delle statemachines.
    /// </summary>
    public abstract class BaseState {

        public struct Context {
            public float IntroCountdown;
            public GlobalUI UI;
            public Action OnStateEnding; // chiamata generica per avvisare che il lavoro dello stato attuale è terminato
        }

        public Context ctx;

        public void Setup(Context _context) {
            ctx = _context;
        }
        /// <summary>
        /// Viene eseguito all'attivazione dello stato.
        /// </summary>
        public virtual void Enter() { }
        /// <summary>
        /// Viene eseguito ad ogni update dello stato se attivo.
        /// </summary>
        public virtual void Tick() { }
        /// <summary>
        /// Viene eseguito alla disattivazione dello stato.
        /// </summary>
        public virtual void Exit() { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace StateMachine {
    public class FL_SplashScreen_State : BaseState {

        public override void Enter() {
            UnityEngine.Debug.Log("Enter FL_SplashScreen_State");
            // visualizza la UI di splash
            ctx.UI.EnableSplashUI(true);
            counter = ctx.IntroCountdown;
        }

        float counter;

        public override void Tick() {
            // - countdown di "ctx.IntroCountdown" sec  
            counter -= Time.deltaTime;
            if (counter <= 0) {
                // - il mio lavoro (SplashScreen_State) è finito
                ctx.OnStateEnding();
            }
        }

        public override void Exit() {
            // nascondi la UI di splash
            ctx.UI.EnableSplashUI(false);
        }
    }
}

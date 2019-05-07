using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup_State : StateBehaviourBase {


    public override void OnEnter() {
        
    }

    public override void OnExit() {
        ctx.SetupDone = true;
        Debug.LogFormat("SetupState {0} in Setup_State", ctx.SetupDone);
    }

}

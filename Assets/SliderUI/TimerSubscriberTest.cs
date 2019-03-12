using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;

public class TimerSubscriberTest : MonoBehaviour
{
    public UITimer Timer;

    private void OnEnable() {
        Timer.EndTimer += endTimerDelegate;
    }

    private void endTimerDelegate() {
        Debug.Log("Timer terminato");
    }

    private void OnDisable() {
        Timer.EndTimer -= endTimerDelegate;
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSubscriberTest : MonoBehaviour
{
    public Slider slider;

    private void OnEnable() {
        slider.EndTimer += endTimerDelegate;
    }

    private void endTimerDelegate() {
        Debug.Log("Timer terminato");
    }

    private void OnDisable() {
        slider.EndTimer -= endTimerDelegate;
    }

}

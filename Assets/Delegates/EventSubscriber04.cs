using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber04 : MonoBehaviour
{
    #region
    public EventDispatcher dispatcher;

    private void OnEnable() {
        dispatcher.OnButtonPressed += onButtonPressed;
    }

    private void OnDisable() {
        
    }
    #endregion

    private void onButtonPressed(KeyCode keycode) {
        Debug.LogFormat("E' stato cliccato il pulsante {0}", keycode);
        dispatcher.OnButtonPressed -= onButtonPressed; // mi disiscrivo dopo la prima callback
    }
}

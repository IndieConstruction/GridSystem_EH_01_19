using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber03 : MonoBehaviour {

    #region

    private void OnEnable() {
        EventDispatcher.MyTurnDelegate += myTurnDelegate;
    }

    private void OnDisable() {
        EventDispatcher.MyTurnDelegate -= myTurnDelegate;
    }

    #endregion

    private void myTurnDelegate(Color color) {
        Debug.LogError("Player turn!");
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber01 : MonoBehaviour
{
    public EventDispatcher dispatcher;

    private void OnEnable() {
        dispatcher.OtherTurnDelegate += doMyTurn;
    }

    private void doMyTurn(Color color) {
        Debug.Log("EventSubscriber01 ricevuto evento OtherTurn: " + color);
    }

    private void OnDisable() {
        dispatcher.OtherTurnDelegate -= doMyTurn;
    }

}

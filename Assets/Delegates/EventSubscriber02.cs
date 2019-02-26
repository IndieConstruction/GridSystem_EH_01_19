using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber02 : MonoBehaviour
{
    public EventDispatcher dispatcher;

    private void OnEnable() {
        dispatcher.OtherTurnDelegate += doMyTurn;
    }

    private void doMyTurn(Color color) {
        Debug.LogWarning("EventSubscriber02 ricevuto evento OtherTurn: " + color);
    }

    private void OnDisable() {
        dispatcher.OtherTurnDelegate -= doMyTurn;
    }

}

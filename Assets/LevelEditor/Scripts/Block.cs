using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private SpriteRenderer CrackableSprite;

    public enum crackableState { normal, almostBroken, broken }

    public crackableState CurrentCrackableState {
        get {
            return _currentCrackableState;
        }
        set {
            if (value == _currentCrackableState)
                return;
            crackableState tmpOldState = _currentCrackableState;
            _currentCrackableState = value;
            onStateChanged(tmpOldState, _currentCrackableState);
        }
    }
    [SerializeField] private crackableState _currentCrackableState;


    public crackableState currentState = crackableState.normal;

    public ItemData GetData() {
        ItemData itemData = new ItemData() {
            GridPosition = transform.position,
            ItemType = ItemData.Type.Block,
        };
        
        return itemData;
    }

    #region Crackable state

    #endregion

    private void onStateChanged(crackableState _oldState, crackableState _newState) {
        Debug.LogFormat("Stage changed: {0} -> {1}", _oldState, _newState);
        switch (_newState) {
            case crackableState.normal:
                CrackableSprite.color = Color.white;
                break;
            case crackableState.almostBroken:
                CrackableSprite.color = Color.yellow;
                break;
            case crackableState.broken:
                CrackableSprite.color = Color.red;
                break;
            default:
                break;
        }
    }

    private void Update() {
        switch (CurrentCrackableState) {
            case crackableState.normal:
                
                break;
            case crackableState.almostBroken:
                
                break;
            case crackableState.broken:
                
                break;
            default:
                break;
        }
    }
}

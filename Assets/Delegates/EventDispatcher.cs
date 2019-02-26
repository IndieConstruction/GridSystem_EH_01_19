using System;
using System.Collections.Generic;
using UnityEngine;

public class EventDispatcher : MonoBehaviour
{
    #region delegates
    public delegate void MyDelegate(Color color);

    public MyDelegate OtherTurnDelegate;
    public static MyDelegate MyTurnDelegate;
    #endregion

    #region Actions

    public Action OnDispatcherStarded;
    public Action<KeyCode> OnButtonPressed;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if(OtherTurnDelegate != null)
            OtherTurnDelegate(Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            MyTurnDelegate(Color.blue);

            if (OnButtonPressed != null)
                OnButtonPressed(KeyCode.Space);
        }
    }
}

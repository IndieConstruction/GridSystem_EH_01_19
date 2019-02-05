using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public KeyCode UpButton;
    public KeyCode DownButton;
    public KeyCode LeftButton;
    public KeyCode RightButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(LeftButton)) {
            // left
            SendMessage("GoToLeft");
        }
        if (Input.GetKeyDown(RightButton)) {
            // right
            SendMessage("GoToRight");
        }
        if (Input.GetKeyDown(UpButton)) {
            // up
            SendMessage("GoToUp");
        }
        if (Input.GetKeyDown(DownButton)) {
            // down
            SendMessage("GoToDown");
        }
    }
}

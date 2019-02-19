using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTester : MonoBehaviour
{
    [SerializeField] private Block BlockToTest;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            BlockToTest.CurrentCrackableState = Block.crackableState.normal;
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            BlockToTest.CurrentCrackableState = Block.crackableState.almostBroken;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            BlockToTest.CurrentCrackableState = Block.crackableState.broken;
        }
    }
}

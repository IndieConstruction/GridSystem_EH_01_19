using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class PositionTester : MonoBehaviour {

    public int x;
    public int y;

    public BaseGrid grid;

	// Update is called once per frame
	void Update () {
        if (grid) {
            transform.position = grid.GetWorldPosition(x, y);
        }
        
	}
}

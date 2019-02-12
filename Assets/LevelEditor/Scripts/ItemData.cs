using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData {

    public enum Type { Block, Point, Usable }

    public Vector3 GridPosition;
    public Type ItemType;

}

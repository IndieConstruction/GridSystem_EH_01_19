﻿using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemData {

    public enum Type { Block, Point, Usable }

    public Vector3 GridPosition;
    public Type ItemType;

}

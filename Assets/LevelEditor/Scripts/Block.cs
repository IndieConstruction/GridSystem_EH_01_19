using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public ItemData GetData() {
        ItemData itemData = new ItemData() {
            GridPosition = transform.position,
            ItemType = ItemData.Type.Block,
        };

        return itemData;
    }
}

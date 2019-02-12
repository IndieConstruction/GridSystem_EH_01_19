using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : MonoBehaviour
{
    public ItemData GetData() {
        ItemData itemData = new ItemData() {
            GridPosition = transform.position,
            ItemType = ItemData.Type.Usable,
        };

        return itemData;
    }
}

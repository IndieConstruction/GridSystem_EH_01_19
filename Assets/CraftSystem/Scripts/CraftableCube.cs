using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftableCube : MonoBehaviour , ICraftable
{

    public string effect = "";

    public effects GetEffects {
        get {
            return effects.effect1;
        }
    }

    public string GetCraftEffect() {
        return effect.ToLower();
    }

   
}

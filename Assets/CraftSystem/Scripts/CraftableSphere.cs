using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftableSphere : MonoBehaviour , ICraftable
{

    public string effect = "";

    public effects GetEffects {
        get {
            return effects.effect2;
        }
    }

    public string GetCraftEffect() {
        return effect.ToUpper();
    }

}

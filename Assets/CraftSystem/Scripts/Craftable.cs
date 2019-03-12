using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craftable : MonoBehaviour {

    public GameObject object1;
    public GameObject object2;

    private void Update() {
        ICraftable Obj1 = object1.GetComponent<ICraftable>();
        ICraftable Obj2 = object2.GetComponent<ICraftable>();

        if (Obj1 != null && Obj2 != null) {
            Debug.Log(Crafting(Obj1, Obj2));
        } else {
            Debug.Log("Not craftable");
        }
        
    }

    public string Crafting(ICraftable obj1 , ICraftable obj2) {

        switch (obj1.GetEffects) {
            case effects.effect1:
                switch (obj2.GetEffects) {
                    case effects.effect2: Debug.Log("Effetto1 + Effetto2");
                        break;
                    case effects.effect3: Debug.Log("Effetto1 + Effetto3");
                        break;
                    default: Debug.Log("Effetto non compatibile");
                        break;
                }
                break;
            case effects.effect2:
                switch (obj2.GetEffects) {
                    case effects.effect1:
                        Debug.Log("Effetto2 + Effetto1");
                        break;
                    case effects.effect3:
                        Debug.Log("Effetto2 + Effetto3");
                        break;
                    default:
                        Debug.Log("Effetto non compatibile");
                        break;
                }
                break;
            case effects.effect3:
                switch (obj2.GetEffects) {
                    case effects.effect1:
                        Debug.Log("Effetto3 + Effetto1");
                        break;
                    case effects.effect2:
                        Debug.Log("Effetto3 + Effetto2");
                        break;
                    default:
                        Debug.Log("Effetto non compatibile");
                        break;
                }
                break;
            default:
                break;
        }
        return string.Format("Effetto craft: {0} + {1} = ", obj1.GetCraftEffect(), obj2.GetCraftEffect());
    }
}

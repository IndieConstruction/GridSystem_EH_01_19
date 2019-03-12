using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum effects {effect1 , effect2 , effect3};


public interface ICraftable{
    effects GetEffects{ get; }
    string GetCraftEffect();
}



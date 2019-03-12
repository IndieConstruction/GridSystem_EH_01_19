using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    int life = 9;

    public int Life {
        get {
            return life;
        }
    }

    public void Damage(int damageAmount) {
        life -= damageAmount;
        if (life <= 0)
            Destroy(gameObject);
    }

}

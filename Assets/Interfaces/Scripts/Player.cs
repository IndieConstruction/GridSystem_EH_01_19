using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces {

    public class Player : MonoBehaviour, IDamageable {

        int life = 3;

        public int Life {
            get {
                return life;
            }
        }

        public void Damage(int damageAmount) {
            life -= damageAmount;
            if(life <= 0) 
                Destroy(gameObject);
        }

    }
}


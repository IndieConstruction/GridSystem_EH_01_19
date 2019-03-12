using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces {

    public class Wall : MonoBehaviour, IDamageable {

        public int Life {
            get {
                return 0;
            }
        }

        public void Damage(int damageAmount) {
            Debug.Log("Sono indistruttibile!!!!");
        }

    }

}

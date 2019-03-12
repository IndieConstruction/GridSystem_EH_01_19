using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces {

    public class Attacker : MonoBehaviour {

        private void Start() {

            foreach (IDamageable damageable in transform.GetComponentsInChildren<IDamageable>()) {
                Player player = damageable as Player;
                if (player != null) {
                    damageable.Damage(3);
                } else {
                    damageable.Damage(10);
                }
                
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace StateMachine {
    public class GlobalUI : MonoBehaviour {

        public Transform SplashUI;
        public Transform MainMenuUI;


        public void EnableSplashUI(bool enable) {
            SplashUI.gameObject.SetActive(enable);
        }

        public void EnableMainMenuUI(bool enable) {
            MainMenuUI.gameObject.SetActive(enable);
        }

    }
}

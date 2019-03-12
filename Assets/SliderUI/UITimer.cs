using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

namespace UI {

    public class UITimer : MonoBehaviour {
        public Image fillImage;
        public TMPro.TextMeshProUGUI counterText;
        public bool Loop = false;
        public bool StartOnAwake = false;
        [SerializeField] private float countAmount = 5f;
        public Color RingColor;

        public delegate void TimerDelegate();

        public TimerDelegate StartTimer;
        public TimerDelegate EndTimer;

        private void Awake() {
            if (StartOnAwake)
                StartCounter(countAmount);

            fillImage.color = RingColor;
        }

        // Update is called once per frame
        void Update() {
            if (Input.GetKeyDown(KeyCode.A)) {
                StartCounter(countAmount);
            }

            counterText.text = ((int)countAmount + 1).ToString();

        }

        float initialCountAmount;

        void StartCounter(float time) {
            initialCountAmount = time;

            fillImage.DOFillAmount(0, 1 / countAmount)
                .SetSpeedBased(true)
                .SetEase(Ease.Linear);


            DOTween.To(() => countAmount, x => countAmount = x, 0, countAmount)
                .SetEase(Ease.Linear)
                .OnComplete(timerCompleted);
        }

        private void timerCompleted() {
            fillImage.DOFillAmount(1, 0);
            countAmount = initialCountAmount;
            if (EndTimer != null)
                EndTimer();
            if (Loop) {
                StartCounter(countAmount);
            }
        }
    }
}
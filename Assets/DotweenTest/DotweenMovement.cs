using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class DotweenMovement : MonoBehaviour
{
    private void Start() {
        
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            RotateAndMoveRandom();
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            doSequence();
        }

    }

    private void doSequence() {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOShakeScale(1.0f));
        mySequence.Insert(0, GetComponent<MeshRenderer>().material.DOColor(Color.red, 1.0f));
        mySequence.Append(transform.DOShakePosition(1.0f)).AppendInterval(10);
        mySequence.OnComplete(onRotationCompleted);
        mySequence.Play();

    }

    private void RotateAndMoveRandom() {
        transform.DOMove(new Vector3(
            UnityEngine.Random.Range(0, 5),
            UnityEngine.Random.Range(0, 3),
            UnityEngine.Random.Range(0, 3)
            ), 0.5f).SetEase(Ease.OutElastic);

        transform.DOLocalRotate(new Vector3(0, 90, 0), 1.5f, RotateMode.LocalAxisAdd)
            .SetEase(Ease.OutBounce)
            .OnComplete(onRotationCompleted);
    }

    private void onRotationCompleted() {
        RotateAndMoveRandom();
    }
}

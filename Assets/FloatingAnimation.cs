using UnityEngine;
using System.Collections;
using DG.Tweening;

public class FloatingAnimation : MonoBehaviour {

    public Transform animatingTransform;

    public float animationTime = 1.0f;
    public float MoveThreshold = 15f;
    public float StartDelay = 0.0f;

    public bool isAtStart = true;

	// Use this for initialization
	void Start () {
        DOTween.Init();
        animatingTransform = GetComponent<Transform>(); // get the transform

        if(isAtStart)
        StartAnim();
	}

    public void StartAnim() {
        animatingTransform.DOMoveY(animatingTransform.position.y + MoveThreshold, animationTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetDelay(StartDelay);
    }
}

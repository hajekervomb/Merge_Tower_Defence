using System;
using UnityEngine;

[Serializable]
public abstract class BaseViewTower : MonoBehaviour
{
    [SerializeField] private Sprite[] icons = default;
    [SerializeField] private GameObject objAnimShot = default;
    [SerializeField] private GameObject objAnimWait = default;

    public Sprite[] Icons => icons;

    public abstract void AnimationShot();

    public abstract void AnimationWait();
}

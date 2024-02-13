using System;
using UnityEngine;

namespace Tower
{
    [Serializable]
    public abstract class BaseViewTower : MonoBehaviour
    {
        [SerializeField] private GameObject objAnimShot = default;
        [SerializeField] private GameObject objAnimWait = default;

        public abstract void AnimationShot();

        public abstract void AnimationWait();
    }
}
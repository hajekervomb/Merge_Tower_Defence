using System;
using UnityEngine;

namespace Enemy
{
    [Serializable]
    public abstract class BaseViewEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject objAnimHit = default;
        [SerializeField] private GameObject objAnimMove = default;

        public abstract void AnimationHit();

        public abstract void AnimationMove();
    }
}
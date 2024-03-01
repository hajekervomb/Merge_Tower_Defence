using DG.Tweening;
using System;
using UnityEngine;

namespace Enemy
{
    [Serializable]
    public abstract class BaseViewEnemy : MonoBehaviour
    {
        protected Tweener animHit = default;
        protected Tweener animMove = default;

        public abstract void AnimationHit();

        public abstract void AnimationMove();
    }
}
using DG.Tweening;
using UnityEngine;

namespace Wall
{
    public abstract class BaseViewWall : MonoBehaviour
    {
        protected Tweener animDamage = default;

        public abstract void AnimationDamage();
    }
}
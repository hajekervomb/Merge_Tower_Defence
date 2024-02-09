using System;
using UnityEngine;

namespace Enemy
{
    [Serializable]
    public abstract class BaseViewEnemy : MonoBehaviour
    {
        [SerializeField] private Sprite[] icons = default;
        [SerializeField] private Sprite[] weapons = default;
        [SerializeField] private GameObject objAnimHit = default;
        [SerializeField] private GameObject objAnimMove = default;

        public Sprite[] Icons => icons;
        public Sprite[] Weapons => weapons;

        public abstract void AnimationHit();

        public abstract void AnimationMove();
    }
}
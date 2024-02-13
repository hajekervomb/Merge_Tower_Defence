using DG.Tweening;
using UnityEngine;

namespace Wall
{
    public class ViewStandart : BaseViewWall
    {
        [SerializeField] private GameObject wall = default;
        [SerializeField] private float animTime = default;
        [SerializeField] private Ease animType = default;
        [SerializeField] private Vector3 endPos = default;
        [SerializeField] private int loopAmount = default;
        [SerializeField] private LoopType loopType = default;

        public override void AnimationDamage()
        {
            Vector3 startPos = Vector3.one;
            
            animDamage = DOTween.To(() => startPos, x => startPos = x, endPos, animTime).SetEase(animType).SetLoops(loopAmount, loopType).
            OnUpdate(() =>
            {
                wall.transform.localScale = startPos;
            });
        }
    }
}
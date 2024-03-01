using DG.Tweening;
using UnityEngine;

namespace Enemy
{
    public class ViewStandart : BaseViewEnemy
    {
        [Header("Анимация удара")]
        [SerializeField] private GameObject objAnimHit = default;
        [SerializeField] private float animTimeHit = default;
        [SerializeField] private Ease animTypeHit = default;
        [SerializeField] private Vector3 endPosHit = default;
        [SerializeField] private LoopType loopTypeHit = default;
        [Header("Анимация движения")]
        [SerializeField] private GameObject objAnimMove = default;
        [SerializeField] private float animTimeMove = default;
        [SerializeField] private Ease animTypeMove = default;
        [SerializeField] private Vector3 endPosMove = default;
        [SerializeField] private LoopType loopTypeMove = default;

        private bool stopHit = default;
        private bool stopMove = default;

        public override void AnimationHit()
        {
            Quaternion startPos = Quaternion.identity;

            //stopHit = default;
            //stopMove = true;
            //animMove?.Kill();
            //animMove = null;
            objAnimMove.transform.localRotation = startPos;

            animMove = DOTween.To(() => startPos, x => startPos = x, endPosHit, animTimeHit).SetEase(animTypeHit).SetLoops(-1, loopTypeHit).
            OnUpdate(() =>
            {
                if (!stopHit)
                {
                    objAnimHit.transform.localRotation = startPos;
                }
            });
        }

        public override void AnimationMove()
        {
            Quaternion startPos = Quaternion.Euler(0f, 0f, 15f);

            //stopHit = true;
            //stopMove = default;
            //animHit?.Kill();
            //animHit = null;
            objAnimHit.transform.localRotation = Quaternion.identity;

            animMove = DOTween.To(() => startPos, x => startPos = x, endPosMove, animTimeMove).SetEase(animTypeMove).SetLoops(-1, loopTypeMove).
            OnUpdate(() =>
            {
                if (!stopMove)
                {
                    objAnimMove.transform.localRotation = startPos;
                }
            });
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private EnemyEntity entity = default;
        [SerializeField] private BaseViewEnemy view = default;

        private void Update()
        {
            if (Input.GetKey(KeyCode.K))
            {
                view.AnimationHit();
            }
            if (Input.GetKey(KeyCode.L))
            {
                view.AnimationMove();
            }
        }
    }
}
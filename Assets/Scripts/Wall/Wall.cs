using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Wall
{
    public class Wall : MonoBehaviour
    {
        [SerializeField] private WallEntity entity = default;
        [SerializeField] private BaseViewWall view = default;
        [SerializeField] private TextMeshPro textLevel = default;

        private int healthPoints = default;
        private uint level = default;

        private void Update()
        {
            if (Input.GetKey(KeyCode.K))
            {
                view.AnimationDamage();
            }
        }
    }
}
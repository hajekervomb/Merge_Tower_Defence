using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower_", menuName = "ScriptableObjects/Tower", order = 1)]
public class TowerEntitie : ScriptableObject
{
    public string Type = default;
    public Tower[] Towers = default;
}

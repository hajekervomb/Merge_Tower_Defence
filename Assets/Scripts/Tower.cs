using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tower
{
    public string Type = default;
    public uint Level = 1;
    public uint Price = default;
    public uint Damage = default;
    public double RateOfFire = default;
    public BaseTypeShot TypeShot = default;
}

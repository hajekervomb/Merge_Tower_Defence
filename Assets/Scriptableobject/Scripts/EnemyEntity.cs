using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy_", menuName = "ScriptableObjects/Enemy")]
public class EnemyEntity : ScriptableObject
{
    [SerializeField] private int baseHealthPoints = default;
    [SerializeField] private uint baseDamage = default;
    [SerializeField] private uint baseAward = default;
    [SerializeField] private double baseRateOfFire = default;
    [SerializeField] private double baseSpeed = default;
    [SerializeField] private Sprite[] icons = default;
    [SerializeField] private Sprite[] weapons = default;

    [Header("Параметр улучшения для расчёта награды")]
    [SerializeField] [Range(0.01f, 1f)] private double boostForAward = default;

    public int BaseHealthPoints => baseHealthPoints;
    public uint BaseDamage => baseDamage;
    public uint BaseAward => baseAward;
    public double BaseRateOfFire => baseRateOfFire;
    public double BaseSpeed => baseSpeed;
    public Sprite[] Icons => icons;
    public Sprite[] Weapons => weapons;

    public int GetHealthCurrentLevel(uint level)
    {
        return baseHealthPoints * (int)level;
    }

    public uint GetDamageCurrentLevel(uint level)
    {
        return baseDamage * level;
    }

    public double GetAwardCurrentLevel(uint level)
    {
        return baseAward * level * boostForAward;
    }
}

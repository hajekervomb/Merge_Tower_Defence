using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower_", menuName = "ScriptableObjects/Tower")]
public class TowerEntity : ScriptableObject
{
    [SerializeField] private string type = default;
    [SerializeField] private uint level = 1;
    [SerializeField] private uint basePrice = default;
    [SerializeField] private uint baseDamage = default;
    [SerializeField] private double baseRateOfFire = default;
    [SerializeField] private double baseSpeedOfTheBullet = default;
    [SerializeField] private Sprite[] icons = default;
    [Header("Параметр улучшения для расчёта урона")]
    [SerializeField] [Range(0.01f, 1f)] private double boostForDamage = default;
    [Header("Параметр улучшения для расчёта цены")]
    [SerializeField] [Range(0.01f, 1f)] private double boostForPrice = default;

    [HideInInspector] public bool Lock = default;

    public string Type => type;
    public uint Level => level;
    public uint BasePrice => basePrice;
    public uint BaseDamage => baseDamage;
    public double BaseRateOfFire => baseRateOfFire;
    public double BaseSpeedOfTheBullet => baseSpeedOfTheBullet;
    public Sprite[] Icons => icons;

    public double GetDamageCurrentLevel(uint level)
    {
        return baseDamage * level * boostForDamage;
    }

    public double GetPriceCurrentLevel(uint level)
    {
        return basePrice * Math.Pow((1 + boostForPrice), level - 1);
    }
}

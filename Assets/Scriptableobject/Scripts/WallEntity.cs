using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Wall_", menuName = "ScriptableObjects/Wall")]
public class WallEntity : ScriptableObject
{
    [SerializeField] private int baseHealthPoints = default;
    [SerializeField] private uint level = 1;
    [SerializeField] private uint basePrice = default;

    [Header("Параметр улучшения для расчёта цены")]
    [SerializeField] [Range(0.01f, 1f)] private double boostForPrice = default;

    public int BaseHealthPoints => baseHealthPoints;
    public uint Level => level;
    public uint BasePrice => basePrice;


    public int GetHealthCurrentLevel(uint level)
    {
        return baseHealthPoints * (int)level;
    }

    public double GetPriceCurrentLevel(uint level)
    {
        return basePrice * Math.Pow((1 + boostForPrice), level - 1);
    }
}

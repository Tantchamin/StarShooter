using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "CreateCard")]
public class Card : ScriptableObject
{
    public new string name;
    public string desciption;
    public Sprite image;

    public EffectType effectType;

    public enum EffectType
    {
        Barrier,
        Bullet,
        GlassCannon,
        GoldenMissile,
        Missile,
        Repair
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCardEffect : MonoBehaviour
{
    [SerializeField] private DisplayCard card;
    [SerializeField] private CardEffect cardEffect;

    public void ChooseCard()
    {
        switch (card.card.effectType)
        {
            case Card.EffectType.Barrier:
                cardEffect.BarrierEffect();
                break;
            case Card.EffectType.Bullet:
                cardEffect.BulletEffect();
                break;
            case Card.EffectType.GlassCannon:
                cardEffect.GlassCannonEffect();
                break;
            case Card.EffectType.GoldenMissile:
                cardEffect.GoldenMissileEffect();
                break;
            case Card.EffectType.Missile:
                cardEffect.MissileEffect();
                break;
            case Card.EffectType.Repair:
                cardEffect.RepairEffect();
                break;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCardEffect : MonoBehaviour
{
    [SerializeField] private DisplayCard card;
    [SerializeField] private CardEffect cardEffect;
    [SerializeField] private AudioSource audioSource;

    public void ChooseCard()
    {
        switch (card.card.effectType)
        {
            case Card.EffectType.Barrier:
                audioSource.Play();
                cardEffect.BarrierEffect();
                break;
            case Card.EffectType.Bullet:
                audioSource.Play();
                cardEffect.BulletEffect();
                break;
            case Card.EffectType.GlassCannon:
                audioSource.Play();
                cardEffect.GlassCannonEffect();
                break;
            case Card.EffectType.GoldenMissile:
                audioSource.Play();
                cardEffect.GoldenMissileEffect();
                break;
            case Card.EffectType.Missile:
                audioSource.Play();
                cardEffect.MissileEffect();
                break;
            case Card.EffectType.Repair:
                audioSource.Play();
                cardEffect.RepairEffect();
                break;
        }
        
    }
}

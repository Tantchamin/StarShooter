using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCardEffect : MonoBehaviour
{
    [SerializeField] private DisplayCard card;

    public void ChooseCard()
    {
        switch (card.card.effectType)
        {
            case Card.EffectType.Barrier:
                Debug.Log("Barrier");
                break;
            case Card.EffectType.Bullet:
                Debug.Log("Bullet");
                break;
            case Card.EffectType.GlassCannon:
                Debug.Log("GlassCannon");
                break;
            case Card.EffectType.GoldenMissile:
                Debug.Log("GoldenMissile");
                break;
            case Card.EffectType.Missile:
                Debug.Log("Missile");
                break;
            case Card.EffectType.Repair:
                Debug.Log("Repair");
                break;
        }
        
    }
}

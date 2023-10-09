using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatusScript : MonoBehaviour
{
    [SerializeField] private float healthPoint = 3;
    [SerializeField] private float bulletDamage = 1;
    [SerializeField] private float missileDamage = 10;
    [SerializeField] private float missileAmount = 3;
    [SerializeField] private float cardMaxValue = 10;
    [SerializeField] private float cardValue = 0;
    [SerializeField] private AudioSource hited;

    public void BulletDamageAdjust(float damage)
    {
        if(bulletDamage < 10)
            bulletDamage += damage;
    }

    public void MissileAmountAdjust(float amount)
    {
        if (amount == 3)
        {
            missileAmount = 3;
        }
        else
        {
            missileAmount += amount;
        }
    }

    public void MissileDamageAdjust(float damage)
    {
        if(missileDamage < 50)
            missileDamage += damage;
    }

    public void CardValueAdjust(float amount)
    {
        cardValue += amount;
    }

    public float GetBulletDamage()
    {
        return bulletDamage;
    }

    public float GetMissileDamage()
    {
        return missileDamage;
    }

    public float GetMissileAmount()
    {
        return missileAmount;
    }

    public void HealthPointAdjust(float point)
    {
        healthPoint += point;
        if(point < 0)
        {
            hited.Play();
        }
    }

    public float GetHealthPoint()
    {
        return healthPoint;
    }

    public float GetCardValue()
    {
        return cardValue;
    }

    public float GetCardMaxValue()
    {
        return cardMaxValue;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatusScript : MonoBehaviour
{
    [SerializeField] private float healthPoint = 3;
    [SerializeField] private float bulletDamage = 1;
    [SerializeField] private float missileDamage = 10;

    public void BulletDamageAdjust(float damage)
    {
        if(bulletDamage < 10)
            bulletDamage += damage;
    }

    public void MissileDamageAdjust(float damage)
    {
        if(missileDamage < 30)
            missileDamage += damage;
    }

    public float GetBulletDamage()
    {
        return bulletDamage;
    }

    public float GetMissileDamage()
    {
        return missileDamage;
    }

}

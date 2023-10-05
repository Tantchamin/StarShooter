using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffect : MonoBehaviour
{
    [SerializeField] private CharacterStatusScript characterStatusScript;

    public void BarrierEffect()
    {
        Debug.Log("Barrier");
    }

    public void BulletEffect()
    {
        characterStatusScript.BulletDamageAdjust(1);
        Debug.Log("Bullet");
    }

    public void MissileEffect()
    {
        Debug.Log("Missile");
    }

    public void GoldenMissileEffect()
    {
        characterStatusScript.MissileDamageAdjust(10);
        Debug.Log("GoldenMissile");
    }

    public void GlassCannonEffect()
    {
        Debug.Log("GlassCannon");
    }

    public void RepairEffect()
    {
        Debug.Log("Repair");
    }

}

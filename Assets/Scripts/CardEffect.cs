using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffect : MonoBehaviour
{
    [SerializeField] private CharacterStatusScript characterStatusScript;
    [SerializeField] private GameObject barrier;
    [SerializeField] private float barrierTime = 5;

    private void Start()
    {
        barrier.SetActive(false);
    }

    public void BarrierEffect()
    {
        barrier.SetActive(true);
        StartCoroutine(BarrierEndTime());
        Debug.Log("Barrier");
    }

    public void BulletEffect()
    {
        characterStatusScript.BulletDamageAdjust(1);
        Debug.Log("Bullet");
    }

    public void MissileEffect()
    {
        characterStatusScript.MissileAmountAdjust(3);
        Debug.Log("MissileReload");
    }

    public void GoldenMissileEffect()
    {
        characterStatusScript.MissileDamageAdjust(10);
        Debug.Log("GoldenMissile");
    }

    public void GlassCannonEffect()
    {
        if(characterStatusScript.GetHealthPoint() != 1)
        {
            characterStatusScript.HealthPointAdjust(-1);
            characterStatusScript.BulletDamageAdjust(5);
        }
        Debug.Log("GlassCannon");
    }

    public void RepairEffect()
    {
        characterStatusScript.HealthPointAdjust(1);
        Debug.Log("Repair");
    }

    IEnumerator BarrierEndTime()
    {
        yield return new WaitForSeconds(barrierTime);
        barrier.SetActive(false);
    }

}

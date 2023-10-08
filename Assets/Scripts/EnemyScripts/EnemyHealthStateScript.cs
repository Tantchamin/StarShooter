using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthStateScript : MonoBehaviour
{
    [SerializeField] EnemyStatusScript enemyStatusScript;
    [SerializeField] EnemySpawnBulletCirclePattern circlePattern;
    [SerializeField] EnemySpawnBulletSpiralPattern spiralPatterm;

    [SerializeField] List<GameObject> spiralShootPoints;

    Animator anim;
    private bool isStage2 = true, isStage3 = true;

    private void Awake()
    {
        ShootPointsIsEnable(false);
        //spiralPatterm.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        //enemyStatusScript = GetComponent<EnemyStatusScript>();
        //circlePattern = GetComponent<EnemySpawnBulletCirclePattern>();
        //spiralPatterm = GetComponent<EnemySpawnBulletSpiralPattern>();
        

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log("AnimHP: " + healthPoint.Value);


        if (enemyStatusScript.GetHealthPoint() <= enemyStatusScript.GetMaxHealthPoint() && enemyStatusScript.GetHealthPoint() > (enemyStatusScript.GetMaxHealthPoint() * 60) / 100)
        {

        }
        else if (enemyStatusScript.GetHealthPoint() <= (enemyStatusScript.GetMaxHealthPoint() * 60) / 100 && enemyStatusScript.GetHealthPoint() > (enemyStatusScript.GetMaxHealthPoint() * 30) / 100)
        {
            ShootPointsIsEnable(true);
            AnimationSetBool("isStage2", isStage2);
            //spiralPatterm.enabled = true;
        }
        else if (enemyStatusScript.GetHealthPoint() <= (enemyStatusScript.GetMaxHealthPoint() * 30) / 100)
        {
            AnimationSetBool("isStage3", isStage3);
            circlePattern.FireRateAdjust(1);
            SpiralShootRateAdjust(0.1f);
        }

    }

    void AnimationSetBool(string parameterName, bool parameterBool)
    {
        anim.SetBool(parameterName, parameterBool);
    }

    void ShootPointsIsEnable(bool isEnable)
    {
        for (int i = 0; i < spiralShootPoints.Count; i++)
        {
            spiralShootPoints[i].GetComponent<EnemySpawnBulletSpiralPattern>().enabled = isEnable;
        }
    }

    void SpiralShootRateAdjust(float newFireRate)
    {
        for (int i = 0; i < spiralShootPoints.Count; i++)
        {
            spiralShootPoints[i].GetComponent<EnemySpawnBulletSpiralPattern>().FireRateAdjust(newFireRate);
        }
    }
}

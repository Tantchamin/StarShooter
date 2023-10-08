using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthStateScript : MonoBehaviour
{
    EnemyStatusScript enemyStatusScript;
    EnemySpawnBulletCirclePattern circlePattern;
    EnemySpawnBulletSpiralPattern spiralPatterm;
    Animator anim;
    private bool isStage2 = true, isStage3 = true;

    // Start is called before the first frame update
    void Start()
    {
        enemyStatusScript = GetComponent<EnemyStatusScript>();
        circlePattern = GetComponent<EnemySpawnBulletCirclePattern>();
        spiralPatterm = GetComponent<EnemySpawnBulletSpiralPattern>();
        spiralPatterm.enabled = false;

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
            AnimationSetBool("isStage2", isStage2);
            spiralPatterm.enabled = true;
        }
        else if (enemyStatusScript.GetHealthPoint() <= (enemyStatusScript.GetMaxHealthPoint() * 30) / 100)
        {
            AnimationSetBool("isStage3", isStage3);
        }

    }

    void AnimationSetBool(string parameterName, bool parameterBool)
    {
        anim.SetBool(parameterName, parameterBool);
    }
}

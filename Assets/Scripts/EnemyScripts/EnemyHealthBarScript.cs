using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{
    EnemyStatusScript enemyStatusScript;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        enemyStatusScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyStatusScript>();
        slider.maxValue = enemyStatusScript.GetMaxHealthPoint();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = enemyStatusScript.GetHealthPoint();
    }
}

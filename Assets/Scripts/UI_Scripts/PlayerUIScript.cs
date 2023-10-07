using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUIScript : MonoBehaviour
{
    [SerializeField] private List<Image> healthPoint;
    [SerializeField] private List<Image> missileAmount;
    [SerializeField] private TMP_Text bulletDamage, missileDamage;
    [SerializeField] private CharacterStatusScript characterStatusScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletDamage.text = characterStatusScript.GetBulletDamage().ToString();
        missileDamage.text = characterStatusScript.GetMissileDamage().ToString();

        HealthPointImageChange();
        MissileImageChange();

    }

    void HealthPointImageChange()
    {
        if (characterStatusScript.GetHealthPoint() == 0)
        {
            healthPoint[0].color = new Color(0, 0, 0);
            healthPoint[1].color = new Color(0, 0, 0);
            healthPoint[2].color = new Color(0, 0, 0);
        }
        else if (characterStatusScript.GetHealthPoint() == 1)
        {
            healthPoint[0].color = new Color(255, 255, 255);
            healthPoint[1].color = new Color(0, 0, 0);
            healthPoint[2].color = new Color(0, 0, 0);
        }
        else if (characterStatusScript.GetHealthPoint() == 2)
        {
            healthPoint[0].color = new Color(255, 255, 255);
            healthPoint[1].color = new Color(255, 255, 255);
            healthPoint[2].color = new Color(0, 0, 0);
        }
        else if (characterStatusScript.GetHealthPoint() == 3)
        {
            healthPoint[0].color = new Color(255, 255, 255);
            healthPoint[1].color = new Color(255, 255, 255);
            healthPoint[2].color = new Color(255, 255, 255);
        }
    }

    void MissileImageChange()
    {
        if (characterStatusScript.GetMissileAmount() == 0)
        {
            missileAmount[0].color = new Color(0, 0, 0);
            missileAmount[1].color = new Color(0, 0, 0);
            missileAmount[2].color = new Color(0, 0, 0);
        }
        else if (characterStatusScript.GetMissileAmount() == 1)
        {
            missileAmount[0].color = new Color(255, 255, 255);
            missileAmount[1].color = new Color(0, 0, 0);
            missileAmount[2].color = new Color(0, 0, 0);
        }
        else if (characterStatusScript.GetMissileAmount() == 2)
        {
            missileAmount[0].color = new Color(255, 255, 255);
            missileAmount[1].color = new Color(255, 255, 255);
            missileAmount[2].color = new Color(0, 0, 0);
        }
        else if (characterStatusScript.GetMissileAmount() == 3)
        {
            missileAmount[0].color = new Color(255, 255, 255);
            missileAmount[1].color = new Color(255, 255, 255);
            missileAmount[2].color = new Color(255, 255, 255);
        }
    }
}

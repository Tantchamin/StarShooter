using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStatusScript : MonoBehaviour
{
    [SerializeField] private float healthPoint;
    [SerializeField] private float maxHealthPoint;

    // Start is called before the first frame update
    void Awake()
    {
        healthPoint = maxHealthPoint;
    }

    // Update is called once per frame
    void Update()
    {

        if (healthPoint <= 0)
        {

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet") || other.CompareTag("Missile"))
        {
            EnemyHealthAdjust(-other.GetComponent<BulletScript>().GetBulletDamage());
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            other.GetComponent<CharacterStatusScript>().HealthPointAdjust(-3);
        }
    }

    public float GetHealthPoint()
    {
        return healthPoint;
    }

    public float GetMaxHealthPoint()
    {
        return maxHealthPoint;
    }

    public void EnemyHealthAdjust(float damage)
    {
        healthPoint += damage;
    }
}

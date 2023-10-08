using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBulletCirclePattern : MonoBehaviour
{
    [SerializeField] private byte bulletSpawnAmount = 10;
    [SerializeField] private GameObject bullet;

    [SerializeField] private float startAngle = 90f;
    [SerializeField] private float EndAngle = 270f;
    [SerializeField] private float fireRate = 1f;

    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 1f, fireRate);
    }

    private void Fire()
    {
        float angleStep = (EndAngle - startAngle) / bulletSpawnAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletSpawnAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = Instantiate(bullet, transform.position, transform.rotation);
            bul.GetComponent<EnemyBullletScript>().SetMoveDirection(bulDir);

            angle += angleStep;

        }
    }

    public void FireRateAdjust(float newFireRate)
    {
        fireRate = newFireRate;
    }

}

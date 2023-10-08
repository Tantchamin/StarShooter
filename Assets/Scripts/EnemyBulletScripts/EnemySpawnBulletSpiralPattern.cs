using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBulletSpiralPattern : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireRate = 0.2f;

    [SerializeField] private float angle = 0f;
    [SerializeField] private int anglePlus = 20;

    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, fireRate);
    }

    private void Fire()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180);
        float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = Instantiate(bullet, transform.position, transform.rotation);
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.GetComponent<EnemyBullletScript>().SetMoveDirection(bulDir);

        angle += anglePlus;
        if (angle >= 360)
        {
            angle = 0;
        }
    }

    public void FireRateAdjust(float newFireRate)
    {
        fireRate = newFireRate;
    }
}

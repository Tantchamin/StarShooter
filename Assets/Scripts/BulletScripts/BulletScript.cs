using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float bulletDamage;
    private CharacterStatusScript characterStatusScript;

    private void Awake()
    {
        characterStatusScript = GameObject.Find("Player").GetComponent<CharacterStatusScript>();
        if (gameObject.CompareTag("Bullet"))
        {
            bulletDamage = characterStatusScript.GetBulletDamage();
        }
        else
        {
            bulletDamage = characterStatusScript.GetMissileDamage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, moveSpeed*Time.deltaTime, 0);
    }
}

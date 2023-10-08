using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullletScript : MonoBehaviour
{
    private Vector2 moveDirection;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<CharacterStatusScript>().HealthPointAdjust(-1);
            Destroy(gameObject);
        }
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

}

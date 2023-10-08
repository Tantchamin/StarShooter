using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float moveRange = 6.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        if (transform.position.x >= moveRange || transform.position.x <= -moveRange)
        {
            speed *= -1;
        }
    }
}

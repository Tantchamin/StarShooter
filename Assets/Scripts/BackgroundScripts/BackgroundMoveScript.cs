using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour
{
    [SerializeField] private float movePoint = 7.5f, endPoint = -7.5f;
    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -moveSpeed*Time.deltaTime, 0);
        if(transform.position.y <= -endPoint)
        {
            gameObject.transform.position = new Vector3(0, movePoint, 0);
        }
    }
}

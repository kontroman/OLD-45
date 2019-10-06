using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    private Vector3 direction;
    public float speed;

    private void Start()
    {
        direction = new Vector3(gameObject.transform.position.x - 10, gameObject.transform.position.y - 70, gameObject.transform.position.z);    
    }
    private void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, direction, speed*Time.deltaTime);
    }
}

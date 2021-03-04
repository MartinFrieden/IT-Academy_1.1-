using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public float distance = 1f;
    public float speed = 1f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, 
                                         transform.position.y, 
                                         Mathf.PingPong(Time.time*speed, distance));
    }
}

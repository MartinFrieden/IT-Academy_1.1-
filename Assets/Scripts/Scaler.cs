using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float distance = 1f;
    public float speed = 1f;

    void Update()
    {
        transform.localScale = new Vector3(Mathf.PingPong(Time.time * speed, distance),
                                           Mathf.PingPong(Time.time * speed, distance),
                                           Mathf.PingPong(Time.time * speed, distance));
    }
}

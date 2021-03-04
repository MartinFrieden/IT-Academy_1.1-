using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    Vector3 newPos;
    [Header("Set in Inspector")]
    public float time = 1f;
    
    void Start()
    {
        Invoke("Teleportation", time);
    }

    void Teleportation()
    {
        newPos = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        transform.position = newPos;
        Invoke("Teleportation", time);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public List<GameObject> forms;
    int listSize;
    int index;
    GameObject instance;


    void Start()
    {
        listSize = forms.Count;
        index = Random.Range(0,4);
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (instance != null)
            {
                Destroy(instance);
                index = Random.Range(0, 4);
            }
            var rotation = Quaternion.identity;
            var position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
            instance = Instantiate(forms[index], position, rotation);
        }
    }
}

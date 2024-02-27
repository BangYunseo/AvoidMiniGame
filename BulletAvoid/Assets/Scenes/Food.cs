using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Vector3 targetPos;
    Vector3 myPos;

    Vector3 newPos;
    void Start()
    {
        targetPos = GameObject.Find("Player").transform.position;

        myPos = transform.position;

        newPos = (targetPos - myPos) * 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + newPos;
    }
}

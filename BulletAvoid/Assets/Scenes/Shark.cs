using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    Vector3 targetPos;
    Vector3 myPos;

    Vector3 newPos;


    void Start()
    {
        targetPos = GameObject.Find("Player").transform.position;

        myPos = transform.position;

        newPos = (targetPos - myPos) * 0.001f;
        
        Destroy(gameObject, 15f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + newPos;
    }

    // void OnTriggerEnter2D(Collider2D collider){
    //     Destroy(collider.gameObject);
    //     Debug.Log("GAME OVER");
    // }
}

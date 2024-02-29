using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dir == "up"){
            transform.Translate(Vector3.up * 0.1f);
        }
        else if(dir == "left"){
            transform.Translate(Vector3.left * 0.1f);
        }
        else if(dir == "right"){
            transform.Translate(Vector3.right * 0.1f);
        }
        else if(dir == "down"){
            transform.Translate(Vector3.down * 0.1f);
        }
    }
    public void Press_normal(){
        dir = "null";
    }
    public void Press_up(){
        dir = "up";
    }
    public void Press_down(){
        dir = "down";
    }
    public void Press_left(){
        dir = "left";
    }
    public void Press_right(){
        dir = "right";
    }
    void OnTriggerEnter2D(Collider2D collider){
        Debug.Log(collider);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject FoodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeFood", 0f, 1f);
    }

    void MakeFood() {
        GameObject Food;

        float switchV = Random.value;
        float xV = Random.Range(-13f, 13f);
        float yV = Random.Range(-22f, 22f);

        Debug.Log("switchValue : " + switchV + ", xValue : " + xV + ", yValue : " + yV);

        if(switchV > 0.5f) {
            if(Random.value > 0.5f){
                Food = Instantiate(FoodPrefab, new Vector3(-13f, yV, 0f), Quaternion.identity);
            }
            else{
                Food = Instantiate(FoodPrefab, new Vector3(13f, yV, 0f), Quaternion.identity);
            }
        }
        else {
            if(Random.value > 0.5f){
                Food = Instantiate(FoodPrefab, new Vector3(xV, -22f, 0f), Quaternion.identity);
            }
            else{
                Food = Instantiate(FoodPrefab, new Vector3(xV, 22f, 0f), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

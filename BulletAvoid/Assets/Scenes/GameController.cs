using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject FoodPrefab;
    public GameObject uiStartGameObject;
    // Start is called before the first frame update
    
    public void PressStart(){
        uiStartGameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    void MakeFood() {
        GameObject Food;

        float switchV = Random.value;
        float xV = Random.Range(-13f, 13f);
        float yV = Random.Range(-22f, 22f);

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

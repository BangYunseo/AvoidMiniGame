using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject FoodPrefab;
    public GameObject uiStartGameObject;
    public GameObject uiEndGameObject;
    public Text uiTime;
    
    int sec;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    public void PressStart(){
        sec = 0;

        uiStartGameObject.SetActive(false);

        InvokeRepeating("MakeFood", 0f, 1f);
        InvokeRepeating("SetTime", 1f, 1f);
    }

    public void PressRestart(){
        sec = 0;
        uiTime.text = "" + sec;

        GameObject[] Foods = GameObject.FindGameObjectsWithTag("Food");

        foreach (GameObject food in Foods){
            Destroy(food);
        }
        
        uiEndGameObject.SetActive(false);

    }

    void SetTime(){
        sec = sec + 1;
        uiTime.text = sec.ToString();
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

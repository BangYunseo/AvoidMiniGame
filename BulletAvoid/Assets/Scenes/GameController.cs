using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject SharkPrefab;
    public GameObject uiStartGameObject;
    public GameObject uiEndGameObject;
    public Text uiScore;
    
    int score;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    public void PressStart(){
        score = 0;
        uiScore.text = "SCORE : " + score;

        uiStartGameObject.SetActive(false);

        InvokeRepeating("MakeShark", 0f, 0.5f);
        InvokeRepeating("SetScore", 1f, 1f);
    }

    public void PressRestart(){
        score = 0;
        uiScore.text = "SCORE : " + score;

        GameObject[] Sharks = GameObject.FindGameObjectsWithTag("Shark");

        foreach (GameObject Shark in Sharks){
            Destroy(Shark);
        }
        
        uiEndGameObject.SetActive(false);

    }

    void SetScore(){
        score++;
        uiScore.text = "SCORE : " + score.ToString();
    }
    void MakeShark() {
        GameObject Shark;

        float switchV = Random.value;
        float xV = Random.Range(-13f, 13f);
        float yV = Random.Range(-22f, 22f);

        if(switchV > 0.5f) {
            if(Random.value > 0.5f){
                Shark = Instantiate(SharkPrefab, new Vector3(-13f, yV, 0f), Quaternion.identity);
            }
            else{
                Shark = Instantiate(SharkPrefab, new Vector3(13f, yV, 0f), Quaternion.identity);
            }
        }
        else {
            if(Random.value > 0.5f){
                Shark = Instantiate(SharkPrefab, new Vector3(xV, -22f, 0f), Quaternion.identity);
            }
            else{
                Shark = Instantiate(SharkPrefab, new Vector3(xV, 22f, 0f), Quaternion.identity);
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

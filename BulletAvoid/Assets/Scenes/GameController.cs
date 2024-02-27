using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject FoodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Food;
        Food = Instantiate(FoodPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        
        print("Instantiate Food complete!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

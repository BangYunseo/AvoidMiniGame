using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string dir;
    float minX, maxX, minY, maxY;
    float verticalSpeed = 0f; // 수직 속도
    float horizontalSpeed = 0f; // 수평 속도
    float speed = 0.1f;
    float padding = 0.5f;
    
    void Awake(){
        Debug.Log("모험을 시작합니다.");
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 minBound = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 maxBound = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        minX = minBound.x + padding;
        maxX = maxBound.x - padding;
        minY = minBound.y + padding;
        maxY = maxBound.y - padding;
    }

    // Update is called once per frame
    void Update()
    {
        // Mobile
        MovePlayerMobile();

        // PC
        MovePlayerPC();
    }

    void MovePlayerMobile()
    {
        Vector3 newPos = transform.position;

        if (dir == "up")
        {
            verticalSpeed += speed * Time.deltaTime;
            newPos += Vector3.up * speed;
        }
        else if (dir == "left")
        {
            horizontalSpeed -= speed * Time.deltaTime;
            newPos += Vector3.left * speed;
        }
        else if (dir == "right")
        {
            horizontalSpeed += speed * Time.deltaTime;
            newPos += Vector3.right * speed;
        }
        else if (dir == "down")
        {
            verticalSpeed -= speed * Time.deltaTime;
            newPos += Vector3.down * speed;
        }
        
        // 새로운 위치를 화면 경계 내에 고정
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);

        // 캐릭터 위치 업데이트
        transform.position = newPos;
    }

    void MovePlayerPC()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향 설정
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);

        // 이동량에 이동 속도를 곱하여 속도 조절
        movement *= speed;

        // 현재 위치에 이동량을 더하여 새로운 위치 계산
        Vector3 newPos = transform.position + movement;

        // 새로운 위치를 화면 경계 내에 고정
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);

        // 캐릭터 위치 업데이트
        transform.position = newPos;
    }

    public void Press_normal()
    {
        dir = "NULL";
    }
    public void Press_up()
    {
        dir = "up";
    }
    public void Press_down()
    {
        dir = "down";
    }
    public void Press_left()
    {
        dir = "left";
    }
    public void Press_right()
    {
        dir = "right";
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject);
        GameObject.Find("game").GetComponent<GameController>().uiEndGameObject.SetActive(true);
    }
}

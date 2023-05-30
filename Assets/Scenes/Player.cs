using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카멜 명명법
//단어와 단어 사이는 대문자로 구별
//class 이름은 무조건 대문자로 시작
//나머지 변수들 이름은 소문자로 시작

public class Player : MonoBehaviour {

    public GameManager gameManager;

    //접근지시자
    public float speed = 10f;
    public Rigidbody playerRigidbody;

    public Joystick joystick;

	// Use this for initialization
    // 게임이 처음 시작되었을때 한번 실행
	void Start () {
        //playerRigidbody.AddForce(0, 1000, 0);
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    // 화면이 한번 깜빡일때마다 한번 실행
    // 영화 초당 24프레임 // 모바일 1초 30프레임 // PC게임 1초 60프레임 // 콘솔게임 1초 30프레임
    // 1초에 대략 60번 -> 단, 사양에 따라 다르다.
    // 몇 번 실행되는지 정해져 있지는 않다.
	void Update () {

        if (gameManager.isGameOver == true)
        {
            return;
        }

        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        if (moveVector != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveVector);
            transform.Translate(moveVector * speed * Time.deltaTime, Space.World);
        }

        // Debug.Log("화면이 한번 깜빡임");

        // 유저입력을 넣자
        // -1 ~ +1
        // 조이스틱에도 자동으로 대응됨
        // 숫자로 받는 이유는 조이스틱을 살살 미는 정도를 알기 위해
//        float inputX= Input.GetAxis("Horizontal");

 //       float inputZ= Input.GetAxis("Vertical");

  //      float fallSpeed = playerRigidbody.velocity.y;

        // 힘으로 들어가서 관성이 붙음
        // playerRigidbody.AddForce(inputX*speed, 0, inputZ*speed);

//        Vector3 velocity = new Vector3(inputX, 0, inputZ);

//        velocity = velocity * speed;

 //       velocity.y = fallSpeed;

        // (inputX * speed, fallSpeed, inputZ * speed)
//        playerRigidbody.velocity = velocity;



    }
}

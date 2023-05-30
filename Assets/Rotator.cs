using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    //public Transform myTransform;

	// Use this for initialization
	void Start () {
        // myTransform.Rotate(60, 60, 60);
        //소문자 transform 은 바로 나 자신의 transform 으로 찾아들어감
        // transform.Rotate(60, 60, 60);

    }
	
	// Update is called once per frame
	void Update () {
        //1번에 60도를 1초에 60번 -> 3600도
        //Time.deltaTime -> 화면이 한번 깜빡이는 시간 = 한 프레임의 시간
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
    }
}

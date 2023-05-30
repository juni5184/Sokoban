using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;

    public bool isOveraped = false;

	// Use this for initialization
	void Start () {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 트리거인 콜라이더와 충돌할때 자동으로 실행
    // Enter 충돌을 한 그 순간
    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("trigger in");
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    // Exit 붙어있다가 떼어질때
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    // Stay 충돌하고 있는 '동안'
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public ItemBox[] itemBoxes;

    public bool isGameOver;

    //public GameObject winUI;
    //public GameObject scoreObject;
    public GameObject imageFinish;

    public GameObject btnStage2, btnStage3;
    public GameObject imageStage2, imageStage3;

	// Use this for initialization
	void Start () {
        isGameOver = false;

        bool keybool1 = PlayerPrefs.HasKey("highScore1");
        bool keybool2 = PlayerPrefs.HasKey("highScore2");
        Sprite image = Resources.Load<Sprite>("lock2");

        //stage1 의 highscore가 없으면 stage2,3 버튼 막기
        Debug.Log(keybool1 +", "+ keybool2);

        if (keybool1==false)
        {
            btnStage2.GetComponent<Button>().interactable = false;
            btnStage3.GetComponent<Button>().interactable = false;
            imageStage2.GetComponent<Image>().sprite =image;
            imageStage3.GetComponent<Image>().sprite =image;
        }
        //stage2 의 highscore가 없으면 stage3 버튼 막기
        else if (keybool2 == false)
        {
            btnStage3.GetComponent<Button>().interactable = false;
            imageStage3.GetComponent<Image>().sprite = image;
        }
	}

    // Update is called once per frame
    void Update() {

        if (isGameOver == true)
        {
            return;
        }

        //현재 scene이 1이면 highScore1로 Pref저장
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (itemBoxes[i].isOveraped == true)
                {
                    count++;
                }
            }
            if (count >= 4)
            {
                Debug.Log("게임 승리");
                isGameOver = true;
                imageFinish.SetActive(true);
                //winUI.SetActive(true);
                //scoreObject.SetActive(true);
                btnStage2.GetComponent<Button>().interactable = true;
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (itemBoxes[i].isOveraped == true)
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                Debug.Log("게임 승리");
                isGameOver = true;
                imageFinish.SetActive(true);
                //winUI.SetActive(true);
                //scoreObject.SetActive(true);
                btnStage2.GetComponent<Button>().interactable = true;
                btnStage3.GetComponent<Button>().interactable = true;
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (itemBoxes[i].isOveraped == true)
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                Debug.Log("게임 승리");
                isGameOver = true;
                imageFinish.SetActive(true);
                //winUI.SetActive(true);
                //scoreObject.SetActive(true);
            }
        }


    }
}

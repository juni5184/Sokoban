using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    //기록 보여주는 Text
    public Text highScore;
    public Text score;

    public GameManager gameManager;

    //현재기록, 최고기록
    private int record, highRecord;

    // Use this for initialization
    void Start () {
        //public 으로 선언 했을때는 GetComponent 안해줘도 됨
        //score = GameObject.Find("Score").GetComponent<Text>();
        //highScore = GameObject.Find("HighScore").GetComponent<Text>();
        record = 0;
    }

    // Update is called once per frame
    void Update()
    {
        record = Mathf.FloorToInt(Timer.time);

        //게임이 끝났을때
        if (gameManager.isGameOver == true)
        {
            //현재 scene이 1이면 highScore1로 Pref저장
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                //highScore이 없으면 그냥 기록 넣어줘야 하고,
                //highScore이 있으면 그걸 불러와서 넣어줘야 함
                bool keybool = PlayerPrefs.HasKey("highScore1");
                Debug.Log("HashKey1 : " + keybool);

                //Pref 값이 없으면
                if (keybool == false)
                {
                    //Debug.Log("record : " + record); record=> 게임 끝난 시간(초)
                    highScore.text = "Record : " + record;
                    PlayerPrefs.SetInt("highScore1", record);
                }
                //Pref 값이 있으면
                else
                {
                    highRecord = PlayerPrefs.GetInt("highScore1", 0);
                    Debug.Log("highRecord : " + highRecord);
                    highScore.text = "High Record : " + highRecord;
                    if (highRecord > record)
                    {
                        highRecord = record;
                        PlayerPrefs.SetInt("highScore1", highRecord);
                        PlayerPrefs.Save();
                    }
                }
            }
            //두번째 맵 scene
            else if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                bool keybool = PlayerPrefs.HasKey("highScore2");
                //Debug.Log("HashKey2 : " + keybool);

                if (keybool == false)
                {
                    highScore.text = "Record : " + record;
                    PlayerPrefs.SetInt("highScore2", record);
                }
                else
                {
                    highRecord = PlayerPrefs.GetInt("highScore2", 0);
                    //Debug.Log("highRecord : " + highRecord);
                    highScore.text = "High Record : " + highRecord;
                    if (highRecord > record)
                    {
                        highRecord = record;
                        PlayerPrefs.SetInt("highScore2", highRecord);
                        PlayerPrefs.Save();
                    }
                }
            }
            //세번째 맵
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                bool keybool = PlayerPrefs.HasKey("highScore3");
                Debug.Log("HashKey3 : " + keybool);

                if (keybool == false)
                {
                    highScore.text = "Record : " + record;
                    PlayerPrefs.SetInt("highScore3", record);
                }
                else
                {
                    highRecord = PlayerPrefs.GetInt("highScore3", 0);
                    Debug.Log("highRecord : " + highRecord);
                    highScore.text = "High Record : " + highRecord;
                    if (highRecord > record)
                    {
                        highRecord = record;
                        PlayerPrefs.SetInt("highScore3", highRecord);
                        PlayerPrefs.Save();
                    }
                }
            }

            score.text = "Clear Time : " + record.ToString("0");
            return;
        }
    }
}

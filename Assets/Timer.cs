using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public static float time;

    private Text timer;

    public int highRecord;
    public Text high;
    public GameManager gameManager;

    public ButtonClick buttonClick;

  
    // Use this for initialization
    void Start () {
        time = 0;
        timer = GetComponent<Text>();
        Debug.Log("타이머 시작");
        
        //최고점 표시
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            highRecord = PlayerPrefs.GetInt("highScore1", 0);
            high.text = "High Record : " + PlayerPrefs.GetInt("highScore1", 0).ToString();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            highRecord = PlayerPrefs.GetInt("highScore2", 0);
            high.text = "High Record : " + PlayerPrefs.GetInt("highScore2", 0).ToString();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            highRecord = PlayerPrefs.GetInt("highScore3", 0);
            high.text = "High Record : " + PlayerPrefs.GetInt("highScore3", 0).ToString();
        }

    }

    // Update is called once per frame
    void Update() {

        if (gameManager.isGameOver == true)
        {
            return;
        }

        if (buttonClick.menuOn == false) {
            //Debug.Log("menuOff");
            time += Time.deltaTime;
            int t = Mathf.FloorToInt(time);
            timer.text = "Time : " + t.ToString();
        }
        else
        {
            Debug.Log("menuOn");
        }
              
    }


  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonClick : MonoBehaviour {

    public GameObject imageMenu;
    public bool menuOn = false;
    public bool soundOn = true;

    Image btnSound;

    //public Image[] soundImage;
    
    public AudioSource audio;

    public void OnClickRestart()
    {
        //현재 열려 있는 scene을 받아와야 한다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnClickMenu()
    {
        Debug.Log(imageMenu.activeSelf);
        if (imageMenu.activeSelf == false)
        {
            imageMenu.SetActive(true);
            //timer 시간 멈춰줘야 되는데
           // if(PlayerPrefs.)
            menuOn = true;
        }
        else
        {
            imageMenu.SetActive(false);
            //timer 시간 다시 흐르게
            menuOn = false;
        }
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    //close 버튼 눌렀을때 timer 다시 안돌아감, joystick안됨
    //menuOn== false 되어있음
    public void OnClickMenuClose()
    {
        imageMenu.SetActive(false);
        //timer 시간 다시 흐르게
        //menuOn == false;
    }

    public void OnClickSound()
    {
        Sprite[] image = Resources.LoadAll<Sprite>("Sound");

        Debug.Log(image [0]+ ", "+ image[1]);

        if (soundOn == true)
        {
            soundOn = false;
            Debug.Log("sound off");
            this.audio.Stop();

            //sound Off 이미지 변경 해줘야함
            btnSound = GameObject.Find("BtnSound").GetComponent<Image>();
            btnSound.sprite = image[0];

        }
        else if(soundOn == false)
        {
            soundOn = true;
            Debug.Log("sound on");
            this.audio.Play();

            //sound Off 이미지 변경 해줘야함
            btnSound = GameObject.Find("BtnSound").GetComponent<Image>();
            btnSound.sprite = image[1];
        }
    }

    public void OnClickPrevious()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void OnClickNext()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // stage 이동 버튼
    public void OnClickStage1()
    {
        //Debug.Log("버튼1 클릭");
        SceneManager.LoadScene(0);
    }

    public void OnClickStage2()
    {
        //Debug.Log("버튼2 클릭");
        SceneManager.LoadScene(1);
    }

    public void OnClickStage3()
   {
        //Debug.Log("버튼3 클릭");
        SceneManager.LoadScene(2);
    }

}

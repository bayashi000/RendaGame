using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UIを使うとき
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerScript2 : MonoBehaviour
{/*
    //変数宣言
    //ゲームを開始してない状態にする
    bool isPlaying = false;

    //数字
    int count = 0;

    public Text countText;
    public Text timerText;

    public Text buttonText;

    float timer = 10.0f;

    // ゲーム開始時に一度処理
    void Start()
    {
        buttonText.text = "スタート";
    }

    // ゲーム中ずっと処理
    void Update()
    {
        if (isPlaying == true)
        {

            //少数第2位まで
            timerText.text = timer.ToString("f2");
        }
        //0秒下回ったら
        if (timer < 0)
        {
            //ゲームを初めてない状態に戻す
            isPlaying = false;
            timer = 0;
            timerText.text = timer.ToString("f2");

            buttonText.text = "終了";

            PlayerPrefs.SetInt("score", count);

            SceneManager.LoadScene("EndScene");
        }

    }
    public void CountUp()
    {
        //ゲーム開始状態なら
        if (isPlaying == true)
        {
            count++;

            countText.text = count.ToString();

            Debug.Log(count);

        }
        else
        {
            isPlaying = true;
            buttonText.text = "おせ！";
            countText.text = "0";
        }

    }
    */
}






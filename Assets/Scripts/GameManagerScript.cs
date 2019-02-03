using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UIを使う時
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // 変数宣言

    /*
     * bool型
     * true , falseの値どちらかを保持する
     */

     //ゲームを開始していない状態にする
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
        //*
        if (isPlaying == true)
        {
            timer -= Time.deltaTime;
            //小数点第二位まで
            timerText.text = timer.ToString("f2");
        }
        //0秒を下回ったら
        if (timer < 0)
        {
            //ゲームを開始していない状態にする
            isPlaying = false;
            //*
            timer = 0;
            timerText.text = timer.ToString("f2");

            buttonText.text = "終了";

            //画面遷移
            SceneManager.LoadScene("EndScene");
        }

    }
    /*
     * string　文字列　aiu あいう
     * float 1.2222 3,2121
     * int 1,90
     */
     /*
      * if(条件){
      *     条件が成立した時に行う処理    
      * }else{
      *     条件が成立しなかった時の処理    
      * }    
      */    
     //public 外部から
    public void CountUp()
    {
        //ゲーム開始状態なら
        if (isPlaying == true)
        {
            //count = count + 1;
            //count += 1
            count++;

            //ToString()でString型に変換できる
            countText.text = count.ToString();

            Debug.Log(count);
        }
        else
        {
            //ゲームを開始状態にする
            isPlaying = true;
            buttonText.text = "おせ！";
            countText.text = "0";
        }
    }
}

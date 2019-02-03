using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EndSceneManager : MonoBehaviour
{
    public Text lastScoreText;
    public Text highScoreText;

    int lastScore;
    int highScore;

    void Start()
    {
        /*
         * データの読み込み方
         * PlayerPrefs.Getint("保存名");
         * 
         * string型　あいう　abc
         * int型　1 30
         * float 1.22222,3.444
         *      
         */
        lastScore = PlayerPrefs.GetInt("score");
        lastScoreText.text = lastScore.ToString();

        /*
         * データの有無確認
         * PlayerPrefs.HasKey("保存名");
         * 指定した名前で保存したデータがある場合はtrue
         * 指定した名前で保存したデータがない場合はfalse
         * 
         */

         if(PlayerPrefs.HasKey("highScore") == true)
        {
            //2回目以降
            highScore = PlayerPrefs.GetInt("highScore");

            if(lastScore > highScore)
            {
                highScore = lastScore;
                //保存
                PlayerPrefs.SetInt("highScore", highScore);
            }

        }
        else
        {
            //一番初めの時
            highScore = lastScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }

        highScoreText.text = highScore.ToString();


    }
    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit!!!");
        PlayerPrefs.SetInt("volume",1);
        Application.Quit();
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void CloseGame()
    {
        Application.Quit();

        Debug.Log("Quitting game");
    }
}

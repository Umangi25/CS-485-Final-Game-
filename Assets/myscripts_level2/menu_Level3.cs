﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class menu_Level3 : MonoBehaviour
{
    // Start is called before the first frame update
  public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}

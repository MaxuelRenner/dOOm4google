﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(5))
        {
            LoadNextLevel();

        }
    }


    public void LoadNextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

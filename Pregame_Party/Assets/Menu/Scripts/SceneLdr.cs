﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLdr : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayScene(int scneIdx)
    {
        SceneManager.LoadScene(scneIdx);
    }

    public void doExitGame() => Application.Quit();
}

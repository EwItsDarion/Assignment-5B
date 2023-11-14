/*
		 * Darion Jeffries
		 * GameManager.cs
		 * Assignment 6
		 * Is supposed to load the scenes... Doesn't work
		 */
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private string CurrentLevelName = string.Empty;
    #region this code makes this class a singleton
    private static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
    }

    #endregion

    public void LoadLevel(string levelName)
    {
        print("its supposed to work.");
        UnityEngine.AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
        if (ao != null)
        {
            print("unable to load level");
            return;
        }
        CurrentLevelName = levelName;
    }
    public void UnloadLevel(string levelName)
    {
        UnityEngine.AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao != null)
        {

            return;
        }
    }
}

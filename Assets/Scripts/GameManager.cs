using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int currentLevel = 0;

    public string[] levelNames;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        if (PlayerPrefs.HasKey("currentLevel"))
        {
            currentLevel = PlayerPrefs.GetInt("currentLevel");
        }	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenLevel(int newLevelNum)
    {
        SceneManager.LoadScene(levelNames[newLevelNum]);
    }

    public void OpenCurrentLevel()
    {
        OpenLevel(currentLevel);
    }

    public void CloseApplication()
    {
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        
        Application.Quit();
    }
}

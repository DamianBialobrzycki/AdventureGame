using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTransmitter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenCurrentLevel()
    {
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }

    public void CloseApplication()
    {
        PlayerPrefs.SetInt("currentLevel", GameManager.instance.currentLevel);

        Application.Quit();
    }
}

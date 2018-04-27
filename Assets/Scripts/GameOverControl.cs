using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    private GameObject successPanel;
    private GameObject failPanel;
    private GameObject gameOverCanvas;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        gameOverCanvas = GameObject.Find("GameOverCanvas");
        if(gameOverCanvas != null)
        {
            failPanel = gameOverCanvas.transform.GetChild(0).gameObject;
            successPanel = gameOverCanvas.transform.GetChild(1).gameObject;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Baloon")
        {
            Debug.Log("Sukces!");
            successPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (other.gameObject.tag == "Border")
        {
            Debug.Log("Porazka!");
            failPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptMenuButtons : MonoBehaviour {
    
    public Button btnStartComponent;
    public Button btnQuitComponent;
	// Use this for initialization
	void Start () {
        Button btnStartOnUI = btnStartComponent.GetComponent<Button>();
        Button btnQuitOnUI = btnQuitComponent.GetComponent<Button>();

        btnStartOnUI.onClick.AddListener(StartGame);
        btnQuitOnUI.onClick.AddListener(EndOfGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartGame()
    {
        SceneManager.LoadScene("Labirynth", LoadSceneMode.Single);
    }

    void EndOfGame()
    {
        Application.Quit();
    }
}

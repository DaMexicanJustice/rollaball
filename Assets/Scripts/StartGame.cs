using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Script loaded");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartApplication() {
        SceneManager.LoadScene("Minigame");
    }
}

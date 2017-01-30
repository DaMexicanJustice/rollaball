using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Script loaded");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void QuitApplication() {
        Application.Quit();
    }
}

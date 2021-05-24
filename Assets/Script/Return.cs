using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        //Return to the main menu when pressong the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            SceneManager.LoadScene("MainMenu");
        }
	}
}

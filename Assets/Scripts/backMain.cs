using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class backMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
            LoadingScreenManager.LoadScene(0);
            //SceneManager.LoadScene ("mainScene"); 
		}

	}
}

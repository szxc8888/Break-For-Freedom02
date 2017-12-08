using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameClear");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("GameOver");
        }
	}
}

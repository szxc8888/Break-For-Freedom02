﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectbutton : MonoBehaviour {
    public GameObject startbutton;

	// Use this for initialization
    void Start(){
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameSelect");
        
            //startbutton.SetActive(false);

        }

        if (Input.GetKey(KeyCode.Space)){

            //startbutton.SetActive(true);

        }
    }
}

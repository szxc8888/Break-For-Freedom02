using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{

    public void StringArgFunction(string s)
    {
        if (Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene(s);

        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
}


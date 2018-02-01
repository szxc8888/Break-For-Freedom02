using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
<<<<<<< HEAD
=======

>>>>>>> 63576732167fcbc17bfadf685820dc548750579c
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


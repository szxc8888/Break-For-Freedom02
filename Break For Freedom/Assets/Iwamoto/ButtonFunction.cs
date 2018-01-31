using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
<<<<<<< HEAD

=======
    
>>>>>>> 00c803661ad71c8b7d5b6442292066d2acd9d1e9
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


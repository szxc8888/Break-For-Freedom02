using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
<<<<<<< HEAD

    

=======
>>>>>>> 9938256200fa7eef3dd5ace51b7c3bb29872aac9
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


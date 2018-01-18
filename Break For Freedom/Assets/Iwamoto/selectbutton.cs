using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectbutton : MonoBehaviour
{
    Button Button1;
    //public GameObject startbutton;

    // Use this for initialization
    void Start()
    {
        Button1 = GameObject.Find("/Canvas/Button1").GetComponent<Button>();

        Button1.Select();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    SceneManager.LoadScene("GameSelect");
        //}
    }
}

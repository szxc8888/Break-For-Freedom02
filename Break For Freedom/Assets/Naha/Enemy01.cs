﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy01 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Stage02");
        }
    }
}
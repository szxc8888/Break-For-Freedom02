﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Enemy2 : MonoBehaviour
{

    private static GameObject bikkuri;

    void Start()
    {
        bikkuri = GameObject.Find("bikkuri");

    }
    // Enemy2の当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")   // 囚人服の場合(デフォルト)
        {
            SceneManager.LoadScene("Stage01");    // Enemy1,2,3に触れたらGAMEOVER
        }
        if (other.gameObject.tag == "wear1")    // 看守服の場合
        {
            SceneManager.LoadScene("Stage01");    // Enemy2,3に触れたらGAMEOVER
        }

    }

}
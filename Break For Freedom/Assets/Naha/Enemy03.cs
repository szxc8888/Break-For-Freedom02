﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Enemy03 : MonoBehaviour
{

    // Enemy3の当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        //   if (other.gameObject.tag == "Player")   // 囚人服の場合(デフォルト)
        //   {
        //       SceneManager.LoadScene("Enemy");    // Enemy1,2,3に触れたらGAMEOVER
        //   }
        //   if (other.gameObject.tag == "wear1")    // 看守服の場合
        //   {
        //       SceneManager.LoadScene("Enemy");    // Enemy2,3に触れたらGAMEOVER
        //   }
        if (other.gameObject.tag == "wear2")    // 〇〇の場合
        {
            SceneManager.LoadScene("Stage02");    // Enemy3に触れたらGAMEOVER
        }
    }
}

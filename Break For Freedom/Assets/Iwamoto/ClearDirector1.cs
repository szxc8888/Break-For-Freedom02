using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     //UIを使用可能にする

public class ClearDirector1 : MonoBehaviour {

    //private GameObject Clear; //点滅させたい文字
    public float speed = 0.01f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数

	// Use this for initialization
	void Start () {

        //Clear = GameObject.Find("/Canvas/Clear");

        //Panelの色を取得
        red = GetComponent<Text>().color.r;
        green = GetComponent<Text>().color.g;
        blue = GetComponent<Text>().color.b;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().color = new Color(red, green, blue, alfa);
        alfa += speed;
	}
}

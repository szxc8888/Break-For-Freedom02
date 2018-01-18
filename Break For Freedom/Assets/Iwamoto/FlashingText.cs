using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingText : MonoBehaviour
{

    private GameObject START; //点滅させたい文字

    private float nextTime;
    public float interval = 2.0f; //点滅周期


    // Use this for initialization
    void Start()
    {
        START = GameObject.Find("/Canvas/START");

        nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //一定時間ごとに点滅
        if (Time.time > nextTime)
        {
            float alpha = START.GetComponent<CanvasRenderer>().GetAlpha();
            if (alpha == 1.0f)
                START.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            else
                START.GetComponent<CanvasRenderer>().SetAlpha(1.0f);

            nextTime += interval;
        }

    }
}
using System.Collections;
using UnityEngine;

public class CharaController : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        //左矢印が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }

        //右矢印が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }

        //上矢印が押された時
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }

        //上矢印が押された時
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wear1 : MonoBehaviour {



    GameObject player, wear1, wear2, wear3, key1, Door1,Door12;


    public Sprite moguraImage;
    public Sprite moguraImage2;
    public Sprite moguraImage3;
    public AudioClip sound;

     //  public bool isActive = true;




    void Start()
    {
        this.player = GameObject.Find("Player");
        this.wear1 = GameObject.Find("wear1");
        this.wear2 = GameObject.Find("wear2");
        this.wear3 = GameObject.Find("wear3");

        this.Door1 = GameObject.Find("Door1");

    }

    // Update is called once per frame
    void Update()
    {


    }
    // 服に触れたら着替える
    void OnTriggerEnter2D(Collider2D other)
    {
        //Wear1に触れたら着替える
        if (other.gameObject.tag == "wear1")

        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            this.tag = "wear1";                // タグを変更する
           
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage;     // 画像変更枠追加
             Destroy(gameObject);      // Wear1削除
        }


        // Wear2に触れたら着替える
        if (other.gameObject.tag == "wear2")
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            this.tag = "wear2";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage2;    // 画像変更枠追加

            //  Destroy(wear1);    // Wear1削除
              Destroy(gameObject);    // Wear2削除
        }

        // Wear3に触れたら着替える
        if (other.gameObject.tag == "wear3")

        {
            AudioSource.PlayClipAtPoint(sound, transform.position);

            this.tag = "wear3";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage3;    // 画像変更枠追加

            //  Destroy(wear1);      // Wear1削除
            //  Destroy(wear2);      // Wear2削除
              Destroy(gameObject);      // Wear3削除

        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    GameObject player, wear1, wear2, wear3, key1, Door1, Door12;
    public float speed = 5;
    private Animator animator;


    public Sprite moguraImage;
    public Sprite moguraImage2;
    public Sprite moguraImage3;

    private static GameObject bikkuri;


    void Start()
    {
        this.player = GameObject.Find("Player");
        this.wear1 = GameObject.Find("wear1");
        this.wear2 = GameObject.Find("wear2");
        this.wear3 = GameObject.Find("wear3");
        bikkuri = GameObject.Find("bikkuri");
        this.Door1 = GameObject.Find("Door1");

        animator = GetComponent<Animator>();


    }




    void Update()
    {


        // 右・左
        float x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetFloat("Horizontal", 1f);
            animator.SetFloat("Vertical", 0f);
            transform.Translate(Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetFloat("Horizontal", -1f);
            animator.SetFloat("Vertical", 0f);
            transform.Translate(-Time.deltaTime, 0, 0);
        }
        // 上・下
        float y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetFloat("Horizontal", 0f);
            animator.SetFloat("Vertical", 1f);
            transform.Translate(0, Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetFloat("Horizontal", 0f);
            animator.SetFloat("Vertical", -1f);
            transform.Translate(0, -Time.deltaTime, 0);
        }
        // 移動する向きを求める
        Vector2 direction = new Vector2(x, y).normalized;

        // 移動する向きとスピードを代入する
        animator.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }



    // (↑)上に移動
    //if (Input.GetKey(KeyCode.UpArrow))
    //{
    //    transform.Translate(0, 0.1f, 0);
    //}
    // (↓)下に移動
    //if (Input.GetKey(KeyCode.DownArrow))
    //{
    //    transform.Translate(0, -0.1f, 0);
    //}
    //  (←)左に移動
    // if (Input.GetKey(KeyCode.LeftArrow))
    //{
    //    transform.Translate(-0.1f, 0, 0);
    //}
    // (→)右に移動
    //if (Input.GetKey(KeyCode.RightArrow))
    //{
    //    transform.Translate(0.1f, 0, 0);
    //}

    //}

    // 服に触れたら着替える
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "wear3")
        {
            animator.Play("K Down");
            // animator.Play("K Up");
            //animator.SetBool("wear11", true);
            //   animator.SetBool("wear22", false);
            //   animator.SetBool("wear33", false);
            this.tag = "wear3";
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage;     // 画像変更枠追加
            // Destroy(wear1);      // Wear1削除

        }


        // Wear2に触れたら着替える
        if (other.gameObject.tag == "wear1")
        {

            animator.Play("S Down");
            //   animator.SetBool("wear11", false);
            //   animator.SetBool("wear22", true);
            //   animator.SetBool("wear33", false);
            this.tag = "wear1";                // タグをwear2に変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage2;    // 画像変更枠追加
            //  Destroy(wear1);    // Wear1削除
            //  Destroy(wear2);    // Wear2削除
        }

        // Wear3に触れたら着替える
        if (other.gameObject.tag == "wear2")
        {
            animator.Play("EK Down");
            //  animator.SetBool("wear11", false);
            //  animator.SetBool("wear22", false);
            //  animator.SetBool("wear33", true);
            this.tag = "wear2";                // タグをwear3の変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage3;    // 画像変更枠追加
            //  Destroy(wear1);      // Wear1削除
            //  Destroy(wear2);      // Wear2削除
            //  Destroy(wear3);      // Wear3削除

        }
    }
}
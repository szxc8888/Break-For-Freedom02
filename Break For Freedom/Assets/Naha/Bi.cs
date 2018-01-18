using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bi : MonoBehaviour
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




    }





    // Enemy2に触れたらビックリマーク出現
    void OnTriggerStay2D(Collider2D other)
    {

        //Wear1に触れたら着替える

        if (other.gameObject.tag == "Enemy1")
        {
            Renderer bikkuriRenderer = bikkuri.GetComponent<Renderer>();
            bikkuriRenderer.enabled = true;
        }
        if (other.gameObject.tag == "Enemy2")
        {
            Renderer bikkuriRenderer = bikkuri.GetComponent<Renderer>();
            bikkuriRenderer.enabled = true;
        }
        if (other.gameObject.tag == "Enemy3")
        {
            Renderer bikkuriRenderer = bikkuri.GetComponent<Renderer>();
            bikkuriRenderer.enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        // Enemy2から離れたらビックリマーク出現
        if (other.gameObject.tag == "Enemy1")
        {
            Renderer bikkuriRenderer = bikkuri.GetComponent<Renderer>();
            bikkuriRenderer.enabled = false;
        }
        if (other.gameObject.tag == "Enemy2")
        {
            Renderer bikkuriRenderer = bikkuri.GetComponent<Renderer>();
            bikkuriRenderer.enabled = false;
        }
        if (other.gameObject.tag == "Enemy3")
        {
            Renderer bikkuriRenderer = bikkuri.GetComponent<Renderer>();
            bikkuriRenderer.enabled = false;
        }
    }
}





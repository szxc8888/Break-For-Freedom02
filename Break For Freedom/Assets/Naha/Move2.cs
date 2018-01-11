using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
[RequireComponent(typeof (Animator))]
public class Move2 : MonoBehaviour{
	private Animator Anim;
 
	void Start(){
		Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Anim.SetFloat("rotationx", 1f);
            Anim.SetFloat("rotationy", 0f);
            transform.Translate(Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Anim.SetFloat("rotationx", -1f);
            Anim.SetFloat("rotationy", 0f);
            transform.Translate(-Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", 1f);
            transform.Translate(0, Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", -1f);
            transform.Translate(0, -Time.deltaTime, 0);
        }
    }
	}
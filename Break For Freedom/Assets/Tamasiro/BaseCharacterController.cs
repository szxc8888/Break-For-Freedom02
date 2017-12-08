using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


[RequireComponent(typeof(BaseMortionController))]
public class BaseCharacterController : MonoBehaviour
{

    private BaseMortionController m_Character;

    private void Awake()
    {
        m_Character = GetComponent<BaseMortionController>();
    }


    private void Update()
    {
    }


    private void FixedUpdate()
    {
        // WASDの入力取得
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        //移動
        m_Character.Move(h, v);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerControler : MonoBehaviour
{
    public float moveSpeed = 25f;
    public float jumpSpeed = 5f;
    private CharacterController controller;
    Vector3 moveDirection;
    public TextMeshProUGUI HpNumber;
    public bool playerAtHouse = false;
    public Indicators indicators_script;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

   
    void Update()
    {
        if(controller.isGrounded) {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            moveDirection = transform.forward * verticalInput + transform.right *horizontalInput;

            if(Input.GetKeyDown(KeyCode.Space)){
                moveDirection.y += jumpSpeed;
            }

        }else {
            moveDirection.y -= 9.81f * Time.deltaTime;
        }
        
        controller.Move(moveDirection * moveSpeed *Time.deltaTime);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Wolf") {
            indicators_script.healthAmount -= 0.5f;
            indicators_script.healthBar.fillAmount = indicators_script.healthAmount / 100;
        }
         if (hit.gameObject.tag == "sos") {
           SceneManager.LoadScene("youwin");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    [Header("Speed Vars")]
    //Value Variables
    public float moveSpeed;
    public float maxSpeed, jumpSpeed;
    public float sensitivity = 100f;
    private float _gravity = 20;
    //Struct - Contains Multiple Variables (eg...3 floats)
    private Vector3 _moveDir;
    private float mouseX, mouseY;
    //Reference Variable
    public CharacterController _charController;
    public Transform cam;

    public bool isGrounded;

    private void Start()
    {
        _charController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        Move();
        CameraController();
    }
    private void Move()
    {
        if (_charController.isGrounded)
        {
            moveSpeed = maxSpeed;
            isGrounded = true;
            //move this direction based off inputs
            _moveDir = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
            if (Input.GetButton("Jump"))
            {
                _moveDir.y = jumpSpeed;
            }
        }
        //Regardless if we are grounded or not
        //apply grvity
        _moveDir.y -= _gravity * Time.deltaTime;
        //apply mo
        _charController.Move(_moveDir * Time.deltaTime);
    }

    void CameraController()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.fixedDeltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity * Time.fixedDeltaTime;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f);

        cam.transform.localRotation = Quaternion.Euler(mouseY, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, mouseX, 0f);
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public float moveSpeed = 10f;
    public float jumpForce = 5f;
    public float gravity = 9.81f;

    private Rigidbody rb;
    private Vector3 moveDirection;
    private float mouseX, mouseY;
    public float sensitivity = 100f;
    public Transform cam;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Camera();

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontal, 0f, vertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        if (Input.GetButton("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        moveDirection.y = rb.velocity.y - gravity * Time.deltaTime;

        rb.velocity = moveDirection;
    }

    void Camera()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.fixedDeltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity * Time.fixedDeltaTime;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f);

        cam.transform.localRotation = Quaternion.Euler(mouseY, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, mouseX, 0f);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float dashSpeed = 1.5f;
    public float jumpPower = 3;

    [SerializeField]
    private InputActionReference jump;

    [SerializeField]
    private InputActionReference move;

    [SerializeField]
    private InputActionReference dash;

    private Rigidbody rb;
    private bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //�L����
        jump.action.Enable();
        move.action.Enable();
        dash.action.Enable();
    }

    void Update()
    {
        //�ړ�
        Vector2 moveInput = move.action.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
        moveDirection.y = 0;
        float dashS;
        if (dash.action.inProgress) dashS = dashSpeed;
        else dashS = 1f;
        moveDirection = moveDirection.normalized * moveSpeed * dashS;
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        //�W�����v
        if (jump.action.triggered && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //�n�ʒ��n����
        if (collision.gameObject.CompareTag("Ground")) isJumping = false;
    }
}

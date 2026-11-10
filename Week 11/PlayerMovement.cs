using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public InputActionAsset _ipa;
    private InputActionMap moveMap;
    private InputAction moveAction;
    private Vector2 moveInput;

    private Vector2 moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveMap = _ipa.FindActionMap("Player");
        moveAction = moveMap.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        moveSpeed.x = moveInput.x;
        moveSpeed.y = moveInput.y;

        rb.linearVelocity = moveSpeed.normalized * speed;
    }
}
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
    public SpriteRenderer sr;
    private Vector2 moveSpeed;
    public Sprite lookup,lookright,lookdown,lookleft;
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
        OrientPlayerSprite();
    }

    void Movement()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        moveSpeed.x = moveInput.x;
        moveSpeed.y = moveInput.y;

        rb.linearVelocity = moveSpeed.normalized * speed;
    }
    void OrientPlayerSprite() 
    {
        // make sprite face x y and -x -y based on W A S D direction
        if (moveInput.x > 0 || moveInput.x < 0 ){
            sr.sprite = lookright;
        }
        if (moveInput.y > 0)
        {
            sr.sprite = lookup;
        }
        if (moveInput.y < 0)
        {
            sr.sprite = lookdown;
        }
        if (moveInput.x > 0) { transform.localScale = new Vector3(1, 1, 1); }
        if (moveInput.x < 0) { transform.localScale = new Vector3(-1, 1, 1); }
    }
}
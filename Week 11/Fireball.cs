using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    public void launch(Vector2 direction)
    {
        rb.linearVelocity = direction * 10f;
    }
}

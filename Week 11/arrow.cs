using UnityEngine;

public class arrow : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float speed = -5f;
    public Rigidbody2D rb;
    void FixedUpdate()
    {
        rb.linearVelocityY = speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health -= 50;
            Destroy(gameObject);
        }
    }
}
   

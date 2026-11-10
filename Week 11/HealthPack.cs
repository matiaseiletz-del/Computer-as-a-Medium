using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.AddHealth(30);
            Destroy(gameObject);
        }
    }
}

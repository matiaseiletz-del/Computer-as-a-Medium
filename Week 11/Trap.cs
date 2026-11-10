using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject arrow;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            Instantiate(arrow).GetComponent<arrow>().playerHealth = playerHealth; 
        }
    }
}

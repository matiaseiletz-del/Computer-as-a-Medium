using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject gameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    bool dead = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameEnd();
    }

    void GameEnd()
    {
        if (playerHealth.health <= 0 && !dead)
        {
            playerHealth.healthText.text = "Health: 0";
            player.SetActive(false);
            gameOverUI.SetActive(true);
            dead = true;
            StartCoroutine(DeathRoutine());
        }
    }

    private IEnumerator DeathRoutine()
    {
        TMP_Text egt = gameOverUI.GetComponent<TMP_Text>();
        yield return new WaitForSeconds(2f);
        egt.text = "Why do you suck.";
        yield return new WaitForSeconds(2f);
        egt.text = "Git Gud";
    }

}
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public PlayerMana playerMana;
    public Animator animator;
    public GameObject fireballPrefab;

    void Update()
    {
        Attack();
    }

    void Attack()
    {

        //Sword Attack
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }

        //Magic Attack
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (playerMana.UseMana(10))
            {
                Instantiate(fireballPrefab, transform.position, Quaternion.identity).GetComponent<Fireball>().launch(GetMouseDir());
            }
        }
    }

    private Vector2 GetMouseDir()
    {
        return (Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()) - transform.position).normalized;
    }
}
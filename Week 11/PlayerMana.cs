using UnityEngine;
using TMPro;

public class PlayerMana : MonoBehaviour
{
    public int mana = 50;
    public TMP_Text manaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float cooldown = 2f;

    private float cooldownRef;


    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;

        if (cooldownRef > 0)
        {
            manaText.color = Color.red;
            cooldownRef -= Time.deltaTime;
        }

        if (cooldownRef <= 0 && mana <= 0)
        {
            manaText.color = Color.white;
            mana = 50;
        }
    }

    public void AddMana(int amount)
    {
        mana += amount;

        if(mana > 100)
        {
            mana = 100;
        }
    }

    public bool UseMana(int amount)
    {
        if (cooldownRef > 0 || mana <= 0)
            return false;

        mana -= amount;

        if (mana <= 0)
        {
            mana = 0;
            cooldownRef = cooldown;
            return false;
        }


        return true;
    }

}

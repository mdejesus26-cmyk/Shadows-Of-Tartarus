using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public Button attackButton;
    public Button magicButton;
    public Button fireButton;
    public Button iceButton;
    public Button thunderButton;
    public Button itemButton;
    public int playerHealth = 10;
    public int enemyHealth = 10;
    public int attackDamage = 3;
    public int fireDamage = 5;
    public int iceDamage = 2;
    public int thunderDamage = 7;
    public EnemyManager enemyScript;
    public GameObject attackToggle;
    public GameObject magicToggle;
    public GameObject fireToggle;
    public GameObject iceToggle;
    public GameObject thunderToggle;
    public GameObject itemToggle;
    public TMP_Text playerHealthUI;
    public TMP_Text enemyHealthUI;
    public GameObject battleScene;
    public bool inBattle;
    public TMP_Text battleText;
    public int healAmount;
    public GameObject backToggle;
    public bool magicMenuIsOpen;
    public bool itemMenuIsOpen;
    public GameObject itemMenu;
    public int itemCount = 3;
    public int playerMp = 10;
    public TMP_Text playerMpUI;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthUI.text = "Player Health: " + playerHealth;
        playerMpUI.text = "MP: " + playerMp;
        enemyHealthUI.text = "Enemy Health: " + enemyHealth;

        if (playerHealth > 10)
        {
            playerHealth = 10;
        }
        if (playerMp > 10)
        {
            playerMp = 10;
        }

        if (enemyHealth < 0 || enemyHealth == 0)
        {
            enemyHealth = 0;
            battleScene.SetActive(false);
            inBattle = false;
        }

        if (playerHealth < 1)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void MagicMenuOpen()
    {
        magicToggle.SetActive(false);
        fireToggle.SetActive(true);
        iceToggle.SetActive(true);
        thunderToggle.SetActive(true);
        attackToggle.SetActive(false);
        backToggle.SetActive(true);
        magicMenuIsOpen = true;
    }

    public void MagicMenuClose()
    {
        magicToggle.SetActive(true);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
        attackToggle.SetActive(false);
        backToggle.SetActive(false);
        magicMenuIsOpen = false;
    }

    public void ItemMenuOpen()
    {
        magicToggle.SetActive(false);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
        attackToggle.SetActive(false);
        backToggle.SetActive(true);
        itemToggle.SetActive(true);
        itemMenu.SetActive(true);
        itemMenuIsOpen = true;
    }

    public void ItemMenuClose()
    {
        magicToggle.SetActive(true);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
        attackToggle.SetActive(false);
        backToggle.SetActive(false);
        itemToggle.SetActive(true);
        itemMenu.SetActive(false);
        itemMenuIsOpen = false;
    }


    public void Back()
    {
        if (magicMenuIsOpen == true)
        { 
        magicToggle.SetActive(true);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
        attackToggle.SetActive(true);
        backToggle.SetActive(false);
        itemToggle.SetActive(true);
        magicMenuIsOpen = false;
        }

        else if (itemMenuIsOpen == true)
        {
        magicToggle.SetActive(true);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
        attackToggle.SetActive(true);
        backToggle.SetActive(false);
        itemToggle.SetActive(true);
        itemMenu.SetActive(false);
        itemMenuIsOpen = false;
        }
    }

    public void Attack()
    {
        if (enemyScript.resistPhys == false)
        {
            attackDamage = 3;
            enemyHealth -= attackDamage;
            playerMp ++;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Slashed Enemy! " + attackDamage + " damage dealt!";
        }
        else if (enemyScript.resistPhys == true)
        {
            attackDamage = 1;
            enemyHealth -= attackDamage;
            playerMp ++;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Slashed Enemy! " + attackDamage + " damage dealt!";
        }
    }


    public void Fire()
    {
        if (playerMp > 3 || playerMp == 3)
        {
            if (enemyScript.resistFire == false)
            {
                fireDamage = 5;
                enemyHealth -= fireDamage;
                playerMp -= 3;
                enemyHealthUI.text = "Enemy Health: " + enemyHealth;
                battleText.text = "Flare casted! " + fireDamage + " damage dealt!";
            }
            else if (enemyScript.resistFire == true)
            {
                fireDamage = 2;
                enemyHealth -= fireDamage;
                playerMp -= 3;
                enemyHealthUI.text = "Enemy Health: " + enemyHealth;
                battleText.text = "Flare casted! " + fireDamage + " damage dealt!";
            }
        }
        else if (playerMp < 3)
        {
            battleText.text = "Insufficent MP!";
        }
    }

    public void Ice()
    {
        if (playerMp > 2 || playerMp == 2)
        {
            if (enemyScript.resistIce == false)
        {
                iceDamage = 2;
                enemyHealth -= iceDamage;
                playerMp -= 2;
                enemyHealthUI.text = "Enemy Health: " + enemyHealth;
                battleText.text = "Deep Freeze casted! " + iceDamage + " damage dealt!";
        }
            else if (enemyScript.resistIce == true)
        {
                iceDamage = 1;
                enemyHealth -= iceDamage;
                playerMp -= 2;
                enemyHealthUI.text = "Enemy Health: " + enemyHealth;
                battleText.text = "Deep Freeze casted! " + iceDamage + " damage dealt!";
        }
        }
        else if (playerMp < 2)
        {
            battleText.text = "Insufficent MP!";
        }
    }

    public void Thunder()
    {
        if (playerMp > 5 || playerMp == 5)
        {
            if (enemyScript.resistThunder == false)
            {
                thunderDamage = 7;
                enemyHealth -= thunderDamage;
                playerMp -= 5;
                enemyHealthUI.text = "Enemy Health: " + enemyHealth;
                battleText.text = "Lightning casted! " + thunderDamage + " damage dealt!";
            }
            else if (enemyScript.resistThunder == true)
            {
                thunderDamage = 2;
                enemyHealth -= thunderDamage;
                playerMp -= 5;
                enemyHealthUI.text = "Enemy Health: " + enemyHealth;
                battleText.text = "Lightning casted! " + thunderDamage + " damage dealt!";
            }
        }
        else if (playerMp < 5)
        {
            battleText.text = "Insufficent MP!";
        }
    }

    public void Potion()
    {
        healAmount = 1;

        if (playerHealth < 10 && itemCount != 0)
        {
            playerHealth += healAmount;
            battleText.text = "Potion used! " + healAmount + " HP resored!";
            itemCount --;
        }

        else if (playerHealth > 10 || playerHealth == 10)
        {
            battleText.text = "Health is full!";
        }

        if (itemCount == 0)
        {
            battleText.text = "No items left!";
        }
        
    }

    public void HiPotion()
    {
        healAmount = 2;

        if (playerHealth < 10 && itemCount != 0)
        {
            playerHealth += healAmount;
            battleText.text = "Hi-Potion used! " + healAmount + " HP resored!";
            itemCount --;
        }

        else if (playerHealth > 10 || playerHealth == 10)
        {
            battleText.text = "Health is full!";
        }

        if (itemCount == 0)
        {
            battleText.text = "No items left!";
        }
        
    }

    public void UltraPotion()
    {
        healAmount = 3;

        if (playerHealth < 10 && itemCount != 0)
        {
            playerHealth += healAmount;
            battleText.text = "Ultra Potion used! " + healAmount + " HP resored!";
            itemCount --;
        }

        else if (playerHealth > 10 || playerHealth == 10)
        {
            battleText.text = "Health is full!";
        }

        if (itemCount == 0)
        {
            battleText.text = "No items left!";
        }
        
    }

    
}

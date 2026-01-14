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
    public int healAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthUI.text = "Player Health: " + playerHealth;
        enemyHealthUI.text = "Enemy Health: " + enemyHealth;

        if (enemyHealth < 0 || enemyHealth == 0)
        {
            enemyHealth = 0;
            battleScene.SetActive(false);
            inBattle = false;
        }
    }

    public void MagicMenuOpen()
    {
        magicToggle.SetActive(false);
        fireToggle.SetActive(true);
        iceToggle.SetActive(true);
        thunderToggle.SetActive(true);
    }

    public void MagicMenuClose()
    {
        magicToggle.SetActive(true);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
    }

    public void Attack()
    {
        if (enemyScript.resistPhys == false)
        {
            attackDamage = 3;
            enemyHealth -= attackDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Slashed Enemy! " + attackDamage + " damage dealt!";
        }
        else if (enemyScript.resistPhys == true)
        {
            attackDamage = 1;
            enemyHealth -= attackDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Slashed Enemy! " + attackDamage + " damage dealt!";
        }
    }


    public void Fire()
    {
        if (enemyScript.resistFire == false)
        {
            fireDamage = 5;
            enemyHealth -= fireDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Flare casted! " + fireDamage + " damage dealt!";
        }
        else if (enemyScript.resistFire == true)
        {
            fireDamage = 2;
            enemyHealth -= fireDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Flare casted! " + fireDamage + " damage dealt!";
        }
    }

    public void Ice()
    {
        if (enemyScript.resistIce == false)
        {
            iceDamage = 2;
            enemyHealth -= iceDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Deep Freeze casted! " + iceDamage + " damage dealt!";
        }
        else if (enemyScript.resistIce == true)
        {
            iceDamage = 1;
            enemyHealth -= iceDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Deep Freeze casted! " + iceDamage + " damage dealt!";
        }
    }

    public void Thunder()
    {
        if (enemyScript.resistThunder == false)
        {
            thunderDamage = 7;
            enemyHealth -= thunderDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Lightning casted! " + thunderDamage + " damage dealt!";
        }
        else if (enemyScript.resistThunder == true)
        {
            thunderDamage = 2;
            enemyHealth -= thunderDamage;
            enemyHealthUI.text = "Enemy Health: " + enemyHealth;
            battleText.text = "Lightning casted! " + thunderDamage + " damage dealt!";
        }
    }

    public void Item()
    {
        if (playerHealth < 10)
        {
            playerHealth += healAmount;
            battleText.text = "Potion used! " + healAmount + " HP resored!";
        }

        else if (playerHealth > 10 || playerHealth == 10)
        {
            battleText.text = "Health is full!";
        }
        
    }
}

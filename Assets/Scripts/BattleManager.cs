using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MagicMenuOpen()
    {
        magicToggle.SetActive(false);
        fireToggle.SetActive(true);
        iceToggle.SetActive(true);
        thunderToggle.SetActive(true);
        Magic();
    }

    void MagicMenuClose()
    {
        magicToggle.SetActive(true);
        fireToggle.SetActive(false);
        iceToggle.SetActive(false);
        thunderToggle.SetActive(false);
    }

    void Attack()
    {
        if (enemyScript.resistPhys == false)
        {
            attackDamage = 3;
            enemyHealth -= attackDamage;
        }
        else if (enemyScript.resistPhys == true)
        {
            attackDamage = 1;
            enemyHealth -= attackDamage;
        }
    }

    void Magic()
    {
        if (enemyScript.resistFire == false)
        {
            fireDamage = 5;
            enemyHealth -= fireDamage;
        }
        else if (enemyScript.resistFire == true)
        {
            fireDamage = 2;
            enemyHealth -= fireDamage;
        }

        if (enemyScript.resistIce == false)
        {
            iceDamage = 2;
            enemyHealth -= iceDamage;
        }
        else if (enemyScript.resistIce == true)
        {
            iceDamage = 1;
            enemyHealth -= iceDamage;
        }

        if (enemyScript.resistThunder == false)
        {
            thunderDamage = 7;
            enemyHealth -= thunderDamage;
        }
        else if (enemyScript.resistThunder == true)
        {
            thunderDamage = 2;
            enemyHealth -= thunderDamage;
        }
    }

    void Item()
    {

    }
}

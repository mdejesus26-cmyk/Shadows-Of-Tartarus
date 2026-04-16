using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : MonoBehaviour
{
    public int enemyHealth = 50;
    public int damageAmount = 0;
    public int playerHealth = 10;
    public TMP_Text inBattleText;
    public EnemyScript emyScript;
    public GameObject player;
    public GameObject flower;
    public GameObject enemy;
    public TMP_Text playerHealthText;
    public TMP_Text enemyHealthText;
    public GameObject battleScene;
    
    // Start is called before the first frame update
    void Start()
    {
        emyScript.StartCoroutine(emyScript.EnemyAttackRoutine());
        player.SetActive(false);
        flower.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthText.text = "Your Health: " + playerHealth;
        enemyHealthText.text = "Enemy Health: " + enemyHealth;
        if (enemyHealth < 1)
        {
            //enemy.SetActive(false);
            battleScene.SetActive(false);
            player.SetActive(true);
        }
    }
    
    public void StartBattle()
    {
       
    }
}

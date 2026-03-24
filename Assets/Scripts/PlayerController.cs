using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector2 movementInput;
    public BattleManager battleScript;
    public SceneManage sceneManage;
    public GameObject level1;
    public GameObject level2;
    public GameObject key;
    public GameObject key2;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //battleScript = GameObject.Find("Battle Manager").GetComponent<BattleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (battleScript.inBattle == false)
        {
            movementInput.x = Input.GetAxisRaw("Horizontal");
            // Either the inputs A/D or the horizontal arrow keys can work.
            movementInput.y = Input.GetAxisRaw("Vertical");
            // Either the inputs W/S or the vertical arrow keys can work.
            camera.transform.position = new Vector3(transform.position.x, transform.position.y, -15.39f);
        }
         if (battleScript.inBattle == true)
        {
            /*rb.velocity = Vector3.zero;
             movementInput.x = 0;
             movementInput.y = 0;*/
             transform.position = new Vector3(1000, 500, transform.position.z);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movementInput * moveSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            sceneManage.battleScene.SetActive(true);
            battleScript = GameObject.Find("Battle Manager").GetComponent<BattleManager>();
            if (battleScript != null)
            {
                battleScript.inBattle = true;
                key.SetActive(false);
                //battleScript.enemyScript.attackMode = true;
                //StartCoroutine(EnemyTurnCoroutine());
            }
            else
            {
                Debug.Log("Script not found");
            }
           
        }
        else if (other.CompareTag("Key 2"))
        {
            sceneManage.battleScene2.SetActive(true);
             battleScript = GameObject.Find("Battle Manager").GetComponent<BattleManager>();
            if (battleScript != null)
            {
                battleScript.inBattle = true;
                key2.SetActive(false);
                //battleScript.enemyScript.attackMode = true;
                //StartCoroutine(EnemyTurnCoroutine());
            }
            else
            {
                Debug.Log("Script not found");
            }
        }
    }

    public IEnumerator EnemyTurnCoroutine()
    {
        while (battleScript.inBattle == true)
        {
            battleScript.enemyScript.attackMode = true;
            yield return new WaitForSeconds(2);
            battleScript.enemyScript.damageAmount = Random.Range(1, 3);
            battleScript.playerHealth -= battleScript.enemyScript.damageAmount;
            battleScript.battleText.text = "Enemy attacks! " + battleScript.enemyScript.damageAmount + " damage dealt!";
            battleScript.enemyScript.shakeScript.Shake(battleScript.enemyScript.duration, battleScript.enemyScript.magnitude);
        }
        
        
    }

}
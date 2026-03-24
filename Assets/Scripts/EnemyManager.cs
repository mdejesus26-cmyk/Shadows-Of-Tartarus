using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyManager : MonoBehaviour
{
    public bool resistPhys;
    public bool resistFire;
    public bool resistIce;
    public bool resistThunder;
    public GameObject enemy;
    public BattleManager battleScript;
    public int action;
    public int damageAmount;
    private CinemachineImpulseSource impulseSource;
    public CamShake shakeScript;
    public float duration = 5;
    public float magnitude = 5;
    public Vector3 startPos;
    public bool attackMode = false;


    // Start is called before the first frame update
    void Awake()
    {
        resistPhys = false;
        resistFire = false;
        resistIce = false;
        resistThunder = false;
        impulseSource = GetComponent<CinemachineImpulseSource>();
        startPos = transform.position;
        
        // if (battleScript.inBattle == true && attackMode == false)
        // {
        //     StartCoroutine(EnemyTurnCoroutine());
        //     Debug.Log("Enemy turn started");
        // }
        // else
        // {
        //     Debug.Log(battleScript.inBattle );
        // }
    }

    void OnEnable()
    {
        if (battleScript.inBattle == true && attackMode == false)
        {
            StartCoroutine(EnemyTurnCoroutine());
            Debug.Log("Enemy turn started");
        }
        else
        {
            Debug.Log(battleScript.inBattle );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator EnemyTurnCoroutine()
    {
        while (true)
        {
            attackMode = true;
            yield return new WaitForSeconds(2);
            damageAmount = Random.Range(1, 3);
            battleScript.playerHealth -= damageAmount;
            battleScript.battleText.text = "Enemy attacks! " + damageAmount + " damage dealt!";
            shakeScript.Shake(duration, magnitude);
        }
        
        
    }

    
}


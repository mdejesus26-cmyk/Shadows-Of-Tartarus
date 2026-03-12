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


    // Start is called before the first frame update
    void Start()
    {
        resistPhys = false;
        resistFire = false;
        resistIce = false;
        resistThunder = false;
        impulseSource = GetComponent<CinemachineImpulseSource>();
        startPos = transform.position;
        
        if (battleScript.inBattle == true)
        {
            StartCoroutine(EnemyTurnCoroutine());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemyTurnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            damageAmount = Random.Range(1, 3);
            battleScript.playerHealth -= damageAmount;
            battleScript.battleText.text = "Enemy attacks! " + damageAmount + " damage dealt!";
            shakeScript.Shake(duration, magnitude);
        }
        
        
    }

    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public BattleSystem battleScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator EnemyAttackRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            battleScript.damageAmount = Random.Range(1, 3);
            battleScript.playerHealth -= battleScript.damageAmount;
            battleScript.inBattleText.text = "Enemy attacks! " + battleScript.damageAmount + " damage dealt!";
        }
    }
}

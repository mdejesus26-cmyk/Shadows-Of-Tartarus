using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    
    private PlayerController playerScript;
    public GameObject player;
    public GameObject level1;
    public GameObject level2;
    public GameObject dialogue;
    public BattleManager battleScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switch()
    {  
        SceneManager.LoadScene("World 2");
        //level2.SetActive(true);
        //level1.SetActive(false);
        //battleScript.battleScene.SetActive(true);
        //battleScript.inBattle = true;
            
        
    }
    
}

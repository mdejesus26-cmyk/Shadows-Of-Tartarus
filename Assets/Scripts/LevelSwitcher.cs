using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    private PlayerController playerScript;
    public GameObject player;
    public GameObject level1;
    public GameObject level2;
    public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.hasKey == true)
        {
            level2.SetActive(true);
            level1.SetActive(false);
            playerScript.hasKey = false;
            dialogue.SetActive(true);
        }
    }
}

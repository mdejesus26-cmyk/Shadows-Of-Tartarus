using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSettingsMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}

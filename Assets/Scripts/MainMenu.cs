using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public Button startButton;
    public Button settingsButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(Play);
        settingsButton.onClick.AddListener(Settings);
        //quitButton.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("World");
    }

    public void Settings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit successfuly called");
    }

}

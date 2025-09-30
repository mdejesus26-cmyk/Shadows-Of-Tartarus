using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(Play);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        mainMenu.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitConfirm : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject confirmMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Confirm()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void Cancel()
    {
        confirmMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}

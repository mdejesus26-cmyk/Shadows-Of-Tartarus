using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject deckMenu;
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
        deckMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}

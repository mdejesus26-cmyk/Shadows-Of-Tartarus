using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rewind : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("World 2");
    }
}

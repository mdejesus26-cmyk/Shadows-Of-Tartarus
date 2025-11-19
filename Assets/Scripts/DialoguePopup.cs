using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePopup : MonoBehaviour
{
    public float displayDuration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is what makes the text appear!
    void OnEnable()
    {
        StartCoroutine(DisableAfterDelay());
    }

    IEnumerator DisableAfterDelay()
    {
        // The specific line that makes the text appear.
        gameObject.SetActive(true);
        yield return new WaitForSeconds(displayDuration);
        // Self explanatory.
        gameObject.SetActive(false);
    }
}
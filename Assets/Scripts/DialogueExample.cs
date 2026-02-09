using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueExample : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueManager dialogueManager;
    void Start()
    {
        dialogueManager.Add_Text_Waitlist_Speaking("Yikes!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

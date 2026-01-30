using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueExample : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueManager dialogueManager;
    void Start()
    {
        dialogueManager.Add_Text_Waitlist_Speaking("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tincidunt velit nec ligula lacinia, ac ultrices turpis commodo. Nulla at ipsum luctus, eleifend arcu vitae, pulvinar ligula. Integer quis diam a libero congue volutpat. Quisque sit amet tortor et velit lacinia auctor sed sed lorem. Quisque ultricies, velit quis pretium elementum.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

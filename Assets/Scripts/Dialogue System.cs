using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Text_Display;
    int speed = 1;
    
    void ChangeText(string Text){
        Text_Display.text = Text;

        int length  = Text.Length;
        for (int i = 0; i < length; i++){
            string letter = Text.Substring(i, i);
            Debug.Log(letter);
        }
    }

    void Start()
    {
        ChangeText("Testing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

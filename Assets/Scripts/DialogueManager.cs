using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Text_Display;
    public RawImage Text_Frame;
    public float speed = 30f; // idk what this represent exactly on the equation but just increase to make it faster lol
    public int Closing_Time = 5; // Close after x seconds
    private bool Skip_Dialogue_Bool = false;
    private bool Typing_Dialogue = false;
    private bool Jump_To_End_Dialogue_Bool = false;
    IEnumerator ChangeText(string Text){
        Typing_Dialogue = true;
        Text_Display.text = "";
        int length_word  = Text.Length;
        for (int i = 0; i < length_word; i++){
            if (Skip_Dialogue_Bool == true)
            {
                Skip_Dialogue_Bool = false;
                Typing_Dialogue = false;
                break;
            }
            char letter = Text[i];
            Debug.Log("index: " + i + ":" + letter);

            Debug.Log(Text_Display.text.Length);
            
            if (Text_Display.text.Contains('_')) // Check if underscore then remove
            {
                Text_Display.text = Text_Display.text.Remove(Text_Display.text.Length - 1);
            }
            Text_Display.text += letter; // Add the current letter
            if (i % 2 == 1) // Only add underscore during even iteration to show animation
            {
               Text_Display.text += "_"; 
            }
            if (letter != ' ' && Jump_To_End_Dialogue_Bool == false) // Skip delay when empty spaces
            {
                yield return new WaitForSeconds(1f / speed);
            }
            if (i == (length_word - 1))
            {
                yield return new WaitForSeconds(Closing_Time); // Close itself when finish
                gameObject.SetActive(false);
                Typing_Dialogue = false;
            }
        }
    }

    public void Add_Text_Waitlist_Speaking(string Text)
    {
        Debug.Log("Start");
        if (gameObject.activeSelf == false)
        {
            gameObject.SetActive(true);
        }
        if (Typing_Dialogue == false)
        {
            StartCoroutine(ChangeText(Text));
        } else
        {
            Debug.Log("Cant start a dialogue without starting finishing current one");
        }
    }
    public void Close_Dialogue()
    {
        Skip_Dialogue_Bool = true;
        gameObject.SetActive(false);
    }
    public void Skip_Dialogue() // THIS SKIPS THE DIALOGUE NOT SPEED IT UP!!!
    {
        if (Typing_Dialogue == true && Skip_Dialogue_Bool == false)
        {
            Skip_Dialogue_Bool = true;
        }
    }
    public void Jump_To_End_Dialogue()
    {
        Jump_To_End_Dialogue_Bool = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

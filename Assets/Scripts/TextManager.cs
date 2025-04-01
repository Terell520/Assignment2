using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public TextMesh Dialoguetext;
    private Queue<string> sentences;
    public float talk;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentences = new Queue<string>(); 
    }

    public void StartText (Text texting)
    {
        Debug.Log("Starting convo with " + texting.name);

        sentences.Clear(); //Clears sentences

        foreach (string sentence in texting.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndText();
            return;
        }
        string sentence = sentences.Dequeue();
        Dialoguetext.text = sentence; //Displays the text from TextMesh

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Return)) // checks if the Return (Enter) is pressed
        {
            nextBox(); //When the check is completed, nextBox is triggered which means DisplayNextSentence is also triggered
        }
    }


    void nextBox()
     {
        DisplayNextSentence(); //Advances to the next sentence
     }


    void EndText()
    {
        Debug.Log("End of convo");
    }
}

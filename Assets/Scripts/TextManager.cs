using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public TextMesh textMesh;
    private Queue<string> sentences;

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
    }

     void Update() // reference to TextMeshPro
     {

     }


    void EndText()
    {
        Debug.Log("End of convo");
    }
}

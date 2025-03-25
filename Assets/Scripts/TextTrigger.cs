using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public Text text; //Linked to Text.cs script

    public void Trigtext ()
    {
        //This locates textmanager.cs script
        FindFirstObjectByType<TextManager>().StartText(text);
    }
}

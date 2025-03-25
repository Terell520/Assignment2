using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Text  //Not mono behavior because it's not sitting on script
{
    public string[] sentences;
    [TextArea(3,10)]
    public string name;
}

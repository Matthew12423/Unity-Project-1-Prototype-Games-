using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOP : MonoBehaviour
{
    public Text text;

    public void Print(string text)
    {
        Debug.Log(text);
        this.text.text += text;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Print("Hello World");
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}

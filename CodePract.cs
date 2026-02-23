using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePract : MonoBehaviour
{
    public TextOP textHandler;
    // Start is called before the first frame update
    void Start()
    {
        int size = 5;
        for(int i = 0; i <= size; i += 1)
        {
            for(int j = 0; j < size; j += 1)
            {
                if(j <= size - i - 1) 
                {
                    textHandler.Print(" ");
                }
                else
                {
                    textHandler.Print("*");
                }
            }
            textHandler.Print("\n");
        }

    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        //textHandler.Print(FormatTime(time));
    }

    public string FormatTime(float time)
    {
        int min = (int)time / 60;
        int sec = (int)time - min * 60;
        int mil = (int)((time - sec - min * 60)*10);
        textHandler.Print(min + ":" + sec + "." + mil);
        string minStr = "";
        string secStr = "";
        if (min < 10) minStr = "0";
        minStr += min;
        if (sec < 10) secStr = "0";
        secStr += sec;        

        return minStr + ":" + secStr + "." + mil;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility 
{
    public static string FormatTime(float time)
    {
        int min = (int)time / 60;
        int sec = (int)time - min * 60;
        int mil = (int)((time - sec - min * 60)*10);
        string minStr = "";
        string secStr = "";
        if (min < 10) minStr = "0";
        minStr += min;
        if (sec < 10) secStr = "0";
        secStr += sec;        

        return minStr + ":" + secStr + "." + mil;
    }
}

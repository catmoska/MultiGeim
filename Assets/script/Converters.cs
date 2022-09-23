using System;
//using UnityEngine;

static class Converters
{
    public static string[] virazenia = new string[]{"","K", "M", "G", "T", "P", "E"};
    public static string convermMoneu(long output,int scruglenia = 2)
    {
        bool znac = output < 0;
        output = Math.Abs(output);
        if(output<1000) return (znac ? "-" : "") + output;
        int output2 = (output.ToString().Length-1) / 3;
        return (znac?"-":"")+ Math.Round((double)output / (double)(Math.Pow(1000, output2)),scruglenia) + virazenia[output2];
    }

}

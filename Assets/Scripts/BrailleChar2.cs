using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrailleChar2 
{
    public bool[] chars= new bool[6];

    public BrailleChar2(bool[] chars)
    {
        this.chars = chars;
    }

    public override string ToString()
    {
        string s = "";
        foreach (var b2 in chars)
        {
            s += b2.ToString();
        }
        return s;
    }
}

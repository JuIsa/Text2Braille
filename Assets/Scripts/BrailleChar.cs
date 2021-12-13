using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrailleChar {
    public bool[][] character;
    public BrailleChar(bool[][] character)
    {
        this.character = character;
    }

    public override string ToString()
    {
        string s = "";
        foreach(var b1 in character)
        {
            foreach(var b2 in b1)
            {
                s += b2.ToString();
            }
        }
        return s;
    }

}

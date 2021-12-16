using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text text;
    public List<BrailleChar> brChar;
    public C2B c2b;
    public List<PhysicalBraille> pbr;

    public void Convert()
    {
        var msg = text.text.ToLower();
        foreach(var s in msg)
        {
            //print(s);
            //print(c2b.GetBrCharFromString(s).ToString());
            pbr[0].SetDots(c2b.GetBrailChar2(s));
        }

        

    }
}

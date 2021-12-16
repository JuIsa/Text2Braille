using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text text;
    public C2B c2b;
    public List<PhysicalBraille> pbr;

    public void Convert()
    {
        var msg = text.text.ToLower();
        for (int i = 0; i < msg.Length; i++)
            pbr[i].SetDots(c2b.GetBrailChar2(msg[i]));
    }
}

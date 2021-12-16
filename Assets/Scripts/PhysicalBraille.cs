using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalBraille :MonoBehaviour
{
    public GameObject[] dots = new GameObject[6];


    public void SetDots(BrailleChar2 bc)
    {
        for(int i = 0; i < 6; i++)
        {
            if (bc.chars[i])
                dots[i].transform.localPosition = new Vector3(dots[i].transform.localPosition.x, 0.5f, dots[i].transform.localPosition.z);
            else
                dots[i].transform.localPosition = new Vector3(dots[i].transform.localPosition.x, -0.2f, dots[i].transform.localPosition.z);
        }
    }
}

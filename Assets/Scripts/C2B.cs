using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2B : MonoBehaviour
{
    private Dictionary<char, BrailleChar> allChars = new Dictionary<char, BrailleChar>()
    {
        { 'a', new BrailleChar(new bool[][] { new bool[] { true, false, false }, new bool[] { false, false, false} })},
        { 'b',  new BrailleChar(new bool[][] { new bool[] { true, true, false},  new bool[]{ false, false,false} })},
        { 'c',  new BrailleChar(new bool[][] { new bool[] { true, false, false},  new bool[]{ true, false,false} })},
        { 'd',  new BrailleChar(new bool[][] { new bool[] { true, false, false},  new bool[]{ true, true,false} })},
        { 'e',  new BrailleChar(new bool[][] { new bool[] { true, false, false},  new bool[]{ false, true,false} })},
        { 'f',  new BrailleChar(new bool[][] { new bool[] { true, true, false},  new bool[]{ true, false,false} })},
        { 'g',  new BrailleChar(new bool[][] { new bool[] { true, true, false},  new bool[]{ true, true, false} })},
        { 'h',  new BrailleChar(new bool[][] { new bool[] { true, true, false},  new bool[]{ false, true, false} })},
        { 'i',  new BrailleChar(new bool[][] { new bool[] { false, true, false},  new bool[]{ true, false,false} })},
        { 'j',  new BrailleChar(new bool[][] { new bool[] { false, true, false},  new bool[]{ true, true, false} })},
        { 'k',  new BrailleChar(new bool[][] { new bool[] { true, false, true },  new bool[]{ false, false,false} })},
        { 'l',  new BrailleChar(new bool[][] { new bool[] { true, true, true},  new bool[]{ true, false,false} })},
        { 'm',  new BrailleChar(new bool[][] { new bool[] { true, false, true},  new bool[]{ true, false,false} })},
        { 'n',  new BrailleChar(new bool[][] { new bool[] { true, false, true},  new bool[]{ true, true, false} })},
        { 'o',  new BrailleChar(new bool[][] { new bool[] { true, false, true},  new bool[]{ false, true,false } })},
        { 'p',  new BrailleChar(new bool[][] { new bool[] { true, true, true },  new bool[]{ true, false,false} })},
        { 'q',  new BrailleChar(new bool[][] { new bool[] { true, true, true },  new bool[]{ true, true, false} })},
        { 'r',  new BrailleChar(new bool[][] { new bool[] { true, true, true },  new bool[]{ false, true,false } })},
        { 's',  new BrailleChar(new bool[][] { new bool[] { false, true, true },  new bool[]{ true, false,false} })},
        { 't',  new BrailleChar(new bool[][] { new bool[] { false, true, true },  new bool[]{ true, true, false} })},
        { 'u',  new BrailleChar(new bool[][] { new bool[] { true, false, true },  new bool[]{ false, false, true } })},
        { 'v',  new BrailleChar(new bool[][] { new bool[] { true, true, true },  new bool[]{ false, false, true } })},
        { 'W',  new BrailleChar(new bool[][] { new bool[] { false, true, false},  new bool[]{ true, true, true } })},
        { 'x',  new BrailleChar(new bool[][] { new bool[] { true, false, true },  new bool[]{ true, false, true } })},
        { 'y',  new BrailleChar(new bool[][] { new bool[] { true, false, true },  new bool[]{ true, true, true } })},
        { 'z',  new BrailleChar(new bool[][] { new bool[] { true, false, true },  new bool[]{ false, true, true } })},
        { ' ',  new BrailleChar(new bool[][] { new bool[] { false, false, false },  new bool[]{ false, false, false } })},

    };

    private Dictionary<char, BrailleChar2> allChars2 = new Dictionary<char, BrailleChar2>()
    {
        {'a', new BrailleChar2(new bool[]{ true, false, false, false, false, false} )},
        {'b', new BrailleChar2(new bool[]{ true, false, true, false, false, false} )},
        {'c', new BrailleChar2(new bool[]{ true, true, false, false, false, false} )},
        {'d', new BrailleChar2(new bool[]{ true, true, false, true, false, false} )},
        {'e', new BrailleChar2(new bool[]{ true, false, false, true,false, false} )},
        {'f', new BrailleChar2(new bool[]{ true, true, true, false,false,false} )},
        {'g', new BrailleChar2(new bool[]{ true, true, true, true, false,false} )},
        {'h', new BrailleChar2(new bool[]{ true, false, true, true, false,false} )},
        {'i', new BrailleChar2(new bool[]{ false, true, true, false,false,false} )},
        {'j', new BrailleChar2(new bool[]{ false, true, true, true, false,false} )},
        {'k', new BrailleChar2(new bool[]{ true, false,false,false, true, false} )},
        {'l', new BrailleChar2(new bool[]{ true, false, true, false, true, false} )},
        {'m', new BrailleChar2(new bool[]{ true, true, false,false, true, false} )},
        {'n', new BrailleChar2(new bool[]{ true, true, false, true, true, false} )},
        {'o', new BrailleChar2(new bool[]{ true, false,false, true, true, false} )},
        {'p', new BrailleChar2(new bool[]{ true, true, true, false, true, false} )},
        {'q', new BrailleChar2(new bool[]{ true, true, true, true, true, false} )},
        {'r', new BrailleChar2(new bool[]{ true, false, true, true, true, false} )},
        {'s', new BrailleChar2(new bool[]{ false, true, true, false, true, false} )},
        {'t', new BrailleChar2(new bool[]{ false, true, true, true, true, false} )},
        {'u', new BrailleChar2(new bool[]{ true, false,false,false, true, true } )},
        {'v', new BrailleChar2(new bool[]{ true, false, true, false, true, true } )},
        {'w', new BrailleChar2(new bool[]{ false, true, true, true, false, true } )},
        {'x', new BrailleChar2(new bool[]{ true, true, false,false, true, true } )},
        {'y', new BrailleChar2(new bool[]{ true, true, false, true, true, true } )},
        {'z', new BrailleChar2(new bool[]{ true, false,false, true, true, true } )},
        {' ', new BrailleChar2(new bool[]{ false, false,false, false, false, false } )},
        {'.', new BrailleChar2(new bool[]{ false, false, true, true, false, true } )},
        {',', new BrailleChar2(new bool[]{ false, false, true, false, false, false } )},
    };
    public BrailleChar GetBrCharFromString(char s)
    {
        return allChars[s];
    }

    public BrailleChar2 GetBrailChar2(char s)
    {
        return allChars2[s];
    }

}

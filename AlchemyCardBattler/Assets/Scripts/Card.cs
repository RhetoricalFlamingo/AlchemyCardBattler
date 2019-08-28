using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class Card
{
//    public int CardCode = 0;
//    public int Viscous = 0;
//
//    public int Temp = 0;
//
//    public int Color = 0;
    
    // visc - 1, color - 2, temp - 3, 

    public int cOne, cTwo, cThree, cFour; // change one, two, etc
    public int eOne, eTwo, eThree, eFour; // effect one, two, etc'
    public int color;

    public string desc, title;

    public Card(string t, int c, int e, int col, string d)
    {
        title = t;
        cOne = c;
        eOne = e;
        color = col;
        desc = d;
    }

    public Card(string t, int c, int e, int c2, int e2, int col, string d)
    {
        title = t;
        cOne = c;
        eOne = e;
        cTwo = c2;
        eTwo = e2;
        color = col;
        desc = d;
    }
    
    public Card(string t, int c, int e, int c2, int e2, int c3, int e3, int col, string d)
    {
        title = t;
        cOne = c;
        eOne = e;
        cTwo = c2;
        eTwo = e2;
        cThree = c3;
        eThree = e3;
        color = col;
        desc = d;
    }
    
    public Card(string t, int c, int e, int c2, int e2, int c3, int e3, int c4, int e4, int col, string d)
    {
        title = t;
        cOne = c;
        eOne = e;
        cTwo = c2;
        eTwo = e2;
        cThree = c3;
        eThree = e3;
        cFour = c4;
        eFour = e4;
        color = col;
        desc = d;
    }
    
}


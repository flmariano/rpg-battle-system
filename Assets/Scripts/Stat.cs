using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    public string name;
    public float baseStat;
    public float multiplier;

    public Stat(string name, float baseStat, float multiplier)
    {
        this.name = name;
        this.baseStat = baseStat;
        this.multiplier = multiplier;
    }
}

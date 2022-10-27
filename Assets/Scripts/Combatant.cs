using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// a class for a combatant's in-battle stats
/// </summary>
public class Combatant
{
    public string name;
    public int level;
    public int exp;

    public float baseHp;
    public List<float> baseResources; // mana, stamina, and whatever other "bars" for resources

    public float baseAttack;
    public float baseDefense;
    public float baseMagicAttack;
    public float baseMagicDefense;
    public float baseSpeed;
    public float baseCritRate;

    /// <summary>
    /// temporary multipliers (buffs, etc)
    /// </summary>
    public float attackMultiplier;
    public float defenseMultiplier;
    public float magicAttackMultiplier;
    public float magicDefenseMultiplier;
    public float speedMultiplier;
    public float critRateMultiplier;

    public List<Stat> otherStats; // potentially include extra rersources here instead

    public void AddStat(string name, float baseStat, float multiplier)
    {
        otherStats.Add(new Stat(name, baseStat, multiplier));
    }
}

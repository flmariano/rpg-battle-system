using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// a move is any action that can be performed in a turn
/// </summary>
public class Move
{
    /// <summary>
    /// chance of success, also used for escape chance etc.
    /// </summary>
    public float accuracy = 1.0f;

    /// <summary>
    /// damage the move deals if it's an attacking move, otherwise should be 0, or negative for healing moves
    /// </summary>
    public float baseDamage = 0;


    public Move(float accuracy, float baseDamage)
    {
        this.accuracy = accuracy;
        this.baseDamage = baseDamage;
    }
}

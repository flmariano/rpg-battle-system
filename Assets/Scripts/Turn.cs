using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn
{
    public int combatantId = -1;
    public int turnId = -1;

    /// <summary>
    /// -1 if it hasn't happened yet, otherwise number of turn it happened (useful for history)
    /// </summary>
    public int happenedAtTurn = -1;

    /// <summary>
    /// the move that should be executed in this turn. note that this is just that move in general and not a specific instance of it
    /// </summary>
    public Move move;

    /// <summary>
    /// list of targets of the move
    /// </summary>
    public List<int> targets = new List<int>();


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public static BattleController instance;

    public enum BattleState
    {
        MoveSelection,
        MoveExecution  // more to be added
    }

    public static List<Turn> turnOrder;
    public static List<Turn> turnHistory;
    public static int numPastTurns = 0; // place that turnOrder starts at in history

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.MoveSelection;
        turnOrder = new List<Turn>();

        InitializeTurnOrder();

        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void InitializeTurnOrder()
    {
        turnOrder.Clear(); // just in case

        // loop thru characters (probs external cos its just one of the possibilities maybe)
    }

    public void ExecuteTurn()
    {
        Turn turn = turnOrder[0];




        // if everything successful
        RemoveFromTurnOrder(0);
    }

    public void AddToTurnOrder(int index, Turn value)
    {
        turnOrder.Insert(index, value);
        turnHistory.Insert(index + numPastTurns, value);
    }

    public void AddToTurnOrder(Turn value) // add turn to end of list
    {
        turnOrder.Add(value);
        turnHistory.Add(value);
    }

    public void RemoveFromTurnOrder(int index)
    {
        turnOrder.RemoveAt(index);
        numPastTurns++;
    }
}
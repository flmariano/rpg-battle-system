using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public enum BattleState
    {
        MoveSelection,
        MoveExecution  // more to be added
    }

    public static List<int> turnOrder;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.MoveSelection;
        turnOrder = new List<int>();

        InitializeTurnOrder();
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

    public void ExecuteNextTurn()
    {

    }

    public void AddToTurnOrder(int index, int value)
    {
        turnOrder.Insert(index, value);
    }

    public void RemoveFromTurnOrder(int index)
    {
        turnOrder.RemoveAt(index);
    }
}

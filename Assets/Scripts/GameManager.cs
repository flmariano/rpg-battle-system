using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Menu,
        Running,
        Paused
    }

    public GameState state;
    
    private BattleController battleController;

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Running;
        battleController = BattleController.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// gets called every turn and then executes the turn
    /// </summary>
    void ExecuteMainGameLoop()
    {
        // initiate move selection sequence if applicable, otherwise just execute the turn

        battleController.ExecuteTurn();
    }


}

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

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Running;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using UnityEngine;

public enum GameState
{
    Start,
    Cup,
    Liner,
    Pad,
    Disc,
    Tampon,
    Quit
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static event Action<GameState> OnGameStateChanged;

    public GameState State => _state;
    private GameState _state;
     
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    void Start()
    {
        UpdateGameState(GameState.Start);
    }
    public void UpdateGameState(GameState gameState)
    {
        if (_state == gameState) return;
        _state = gameState;
        if (gameState == GameState.Quit)
        {
            HandleApplicationQuit();
        }

        OnGameStateChanged?.Invoke(gameState);
    }
    private void HandleApplicationQuit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

using System.Net.Http.Headers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text PlaqueText;
    [SerializeField] GameObject ContentCanvas;
    void Start()
    {
        HandleGameStateChanged(GameManager.Instance.State);
        GameManager.OnGameStateChanged += HandleGameStateChanged;
    }
    void OnDestroy()
    {
        GameManager.OnGameStateChanged -= HandleGameStateChanged;
    }

    public void ToggleContent()
    {
        if (ContentCanvas.activeSelf)
        {
            ContentCanvas.SetActive(false);
        }
        else ContentCanvas.SetActive(true);
    }

    private void HandleGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.Start:
                updateName("");
                break;
            case GameState.Cup:
                updateName("Menstrual Cup");
                break;
            case GameState.Liner:
                updateName("Panty Liner");
                break;
            case GameState.Pad:
                updateName("Menstrual Pad");
                break;
            case GameState.Disc:
                updateName("Menstrual Disc");
                break;
            case GameState.Tampon:
                updateName("Tampon");
                break;
            default:
                break;
        }
    }

    private void updateName(string name)
    {
        PlaqueText.text = name;
    }
}

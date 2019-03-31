using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static GM instance = null;

    public GameState State { get; private set; } = GameState.Menu;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeStateToPaused() {
        State = GameState.Paused;
    }

    public void ChangeStateToPlaying() {
        State = GameState.Playing;
    }

    public void ChangeStateToMenu() {
        State = GameState.Menu;
    }

    public void ChangeStateToDialog() {
        State = GameState.Dialog;
    }

    public void LoadScene(string sceneName) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }  
}

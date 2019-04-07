using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance = null;

    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f); 
    [SerializeField]
    private Transform Tape = null;

    public UIComponents uiComponents;

    SceneData sceneData = new SceneData();

    void Awake() {
        Assert.IsNotNull(Tape);
        if (instance == null) {
            instance = this;
        }
    }
    
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();
    }

    public void IncrementCoinCount() {
        sceneData.coinCount++;
    }

    void DisplayHudData() {
        uiComponents.hud.txtCoinCount.text = "x " + sceneData.coinCount;
    }

    public void SetTapeSpeed(float value) {
        TapeSpeed = new Vector3(value, TapeSpeed.y, TapeSpeed.z);
    }

    public void LoadScene(string sceneName) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }  

    public void ShowLevelCompletePanel() {
        uiComponents.dialogs.LCPanel.SetActive(true);
        uiComponents.dialogs.LCTxtScore.text = "" + sceneData.coinCount;
    }
}

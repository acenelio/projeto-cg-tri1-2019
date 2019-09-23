using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;

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

    public void DecrementLifeCount() {
        sceneData.lifeCount--;
    }

    public int GetLifeCount() {
        return sceneData.lifeCount;
    }

    void DisplayHudData() {
        uiComponents.hud.txtCoinCount.text = "x " + sceneData.coinCount;
        uiComponents.hud.txtLifeCount.text = "x " + sceneData.lifeCount;
    }

    public void SetTapeSpeed(float value) {
        TapeSpeed = new Vector3(value, TapeSpeed.y, TapeSpeed.z);
    }

    public void ShowLevelCompletePanel() {
        uiComponents.levelCompletePanel.panel.SetActive(true);
        uiComponents.levelCompletePanel.txtScore.text = "" + sceneData.coinCount;
    }

    public void ShowGameOverPanel() {
        uiComponents.gameOverPanel.panel.SetActive(true);
        uiComponents.gameOverPanel.txtScore.text = "" + sceneData.coinCount;
    }
}

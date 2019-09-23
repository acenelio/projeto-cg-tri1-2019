using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class UIComponents 
{
    [Serializable]
    public class Hud {

        [Header("Text")]
        public Text txtCoinCount;

        [Header("Text")]
        public Text txtLifeCount; // NAO ESQUECA DE ARRASTAR O OBJETO PRA CA NO UNITY

        [Header("Other")]
        public GameObject panelHud;
    }

    [Serializable]
    public class LevelCompletePanel {

        [Header("Text")]
        public Text txtScore;

        [Header("Other")]
        public GameObject panel;
    }

    [Serializable]
    public class GameOverPanel {

        [Header("Text")]
        public Text txtScore;

        [Header("Other")]
        public GameObject panel;
    }

    public Hud hud;
    public LevelCompletePanel levelCompletePanel;
    public GameOverPanel gameOverPanel;
}

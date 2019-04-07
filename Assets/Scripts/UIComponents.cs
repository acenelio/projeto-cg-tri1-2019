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
        public Text txtLifeCount;

        [Header("Other")]
        public GameObject panelHud;
    }
    [Serializable]
    public class Dialogs {
        public GameObject LCPanel;
        public Text LCTxtScore;
        public GameObject GOPanel;
        public Text GOTxtScore;
    }

    public Hud hud;
    public Dialogs dialogs;

}

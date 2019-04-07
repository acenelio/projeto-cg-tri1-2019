using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSFX audioSFX;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    public void PlaySoundCoinPickup(GameObject obj) {
        AudioSource.PlayClipAtPoint(audioSFX.coinPickup, obj.transform.position);
    }

    public void PlaySoundFail(GameObject obj) {
        AudioSource.PlayClipAtPoint(audioSFX.fail, obj.transform.position);
    }
    public void PlaySoundLevelComplete(GameObject obj) {
        AudioSource.PlayClipAtPoint(audioSFX.levelComplete, obj.transform.position);
    }
}

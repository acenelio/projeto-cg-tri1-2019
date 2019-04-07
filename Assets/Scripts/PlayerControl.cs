using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Coin")) {
            SFXManager.instance.ShowCoinParticles(other.gameObject);
            AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
            Destroy(other.gameObject);
            SceneManager.instance.IncrementCoinCount();
        }
        else if (other.gameObject.CompareTag("ForbiddenArea")) {
            KillPlayer();
        }
        else if (other.gameObject.layer ==  LayerMask.NameToLayer("Enemies")) {
            KillPlayer();
        }
    }

    void KillPlayer() {
        Camera.main.GetComponentInChildren<AudioSource>().mute = true;
        SceneManager.instance.SetTapeSpeed(0f);
        SFXManager.instance.ShowDieParticles(gameObject);
        AudioManager.instance.PlaySoundFail(gameObject);
        Destroy(gameObject);
    }
}

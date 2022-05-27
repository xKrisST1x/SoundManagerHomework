using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _musicSource, _effectSource, _moreSource;
    private void Awake() {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip){
        _effectSource.PlayOneShot(clip); 
    }

    public void ChangeMasterVolume(float value){
        AudioListener.volume = value;
    }

    public void ToggleEffects(){
        _effectSource.mute = !_effectSource.mute;
    }

    public void Togglemusic(){
        _musicSource.mute = !_musicSource.mute;
    }
    
    public void ToggleMore(){
        _moreSource.mute = !_moreSource.mute;
    }
}

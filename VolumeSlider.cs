using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer mixer;
    public string parameterName;

    public void SetVolume(float volume)
    {
        mixer.SetFloat(parameterName, Mathf.Log10(volume) * 20);
    }

}

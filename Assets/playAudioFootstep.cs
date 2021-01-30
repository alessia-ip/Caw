using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioFootstep : MonoBehaviour
{
    AudioSource audioData;
    public AudioClip footstep;

    void OnEnable()
    {
        audioData = GetComponent<AudioSource>();
        audioData.PlayOneShot(footstep);
    }

}

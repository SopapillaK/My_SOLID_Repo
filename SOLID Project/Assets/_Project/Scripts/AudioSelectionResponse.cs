using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public AudioClip onDeselectAudio;
    [SerializeField] public AudioClip onSelectAudio;

    public void OnDeselect(Transform selection)
    {
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(onDeselectAudio);
    }
    public void OnSelect(Transform selection)
    {
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(onSelectAudio);
    }
}

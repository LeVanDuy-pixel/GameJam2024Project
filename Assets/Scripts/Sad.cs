using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sad
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] AudioClip[] audioClips;


    private void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("Sad");
        audioClips = Resources.LoadAll<AudioClip>("Sad");
    }
}

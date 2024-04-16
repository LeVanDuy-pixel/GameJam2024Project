using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panic
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] AudioClip[] audioClips;


    private void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("Panic");
        audioClips = Resources.LoadAll<AudioClip>("Panic");
    }
}

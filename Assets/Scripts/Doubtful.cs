using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doubtful
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] AudioClip[] audioClips;


    private void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("Doubtful");
        audioClips = Resources.LoadAll<AudioClip>("Doubtful");
    }
}
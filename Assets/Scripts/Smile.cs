using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smile 
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] AudioClip[] audioClips;

    
    private void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("Smile");
        audioClips = Resources.LoadAll<AudioClip>("Smile");
    }
}

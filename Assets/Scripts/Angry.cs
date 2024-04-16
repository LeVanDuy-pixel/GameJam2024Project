using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angry
    {
    [SerializeField] Sprite[] sprites;
    [SerializeField] AudioClip[] audioClips;


    private void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("Angry");
        audioClips = Resources.LoadAll<AudioClip>("Angry");
    }
}

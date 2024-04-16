using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotion: MonoBehaviour 
{
    public Sprite[] smileSprites;
    public AudioClip[] smileAudioClips;

    public Sprite[] sadSprites;
    public AudioClip[] sadAudioClips;

    public Sprite[] angrySprites;
    public AudioClip[] angryAudioClips;

    public Sprite[] doubtfulSprites;
    public AudioClip[] doubtfulAudioClips;

    public Sprite[] panicSprites;
    public AudioClip[] panicAudioClips;
    private void Awake()
    {
        smileSprites = Resources.LoadAll<Sprite>("Smile");
        smileAudioClips = Resources.LoadAll<AudioClip>("Smile");

         sadSprites = Resources.LoadAll<Sprite>("Sad");
        sadAudioClips = Resources.LoadAll<AudioClip>("Sad");

        angrySprites = Resources.LoadAll<Sprite>("Angry");
        angryAudioClips = Resources.LoadAll<AudioClip>("Angry");

        doubtfulSprites = Resources.LoadAll<Sprite>("Doubtful");
        doubtfulAudioClips = Resources.LoadAll<AudioClip>("Doubtful");

        panicSprites = Resources.LoadAll<Sprite>("Panic");
        panicAudioClips = Resources.LoadAll<AudioClip>("Panic");


    }
}

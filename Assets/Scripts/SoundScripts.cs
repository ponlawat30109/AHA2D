using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScripts : MonoBehaviour
{
    //public AudioSource source;
    public AudioClip[] sound;
    //void Start()
    //{
    //    source = GetComponent<AudioSource>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    source.Play();
    //}

    public void PlaySound(int index)
    {
        GameObject go = new GameObject("AudioClip");
        MonoBehaviour.DontDestroyOnLoad(go);
        AudioSource source = go.AddComponent<AudioSource>();
        source.clip = sound[index];
        source.Play();
    }

    public void PlayBGM()
    {
        PlaySound(2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource audioFX;

    public Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();

    public bool mute;
    public static SoundManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        LoadData();
    }
    public void LoadData()
    {
        AudioClip[] _audioClips = Resources.LoadAll<AudioClip>("AudioMode1");
        foreach (AudioClip clip in _audioClips)
        {
            audioClips.Add(clip.name, clip);
        }
    }

    //--------------------------------------------



    //-------------------------------------------------------------------
    public void StopAllSound()
    {

        audioFX.Stop();
    }

    public void MuteAllSound()
    {

        audioFX.mute = true;
    }

    public void UnMuteAllSound()
    {

        audioFX.mute = false;
    }
}

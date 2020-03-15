using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource[] audioBG;

    [Header("---------------------BG Music Menu----------------------")]
    public AudioClip MenuStartGame_1;
    public AudioClip MenuStartGame_2;

    public bool muteBGMusic;
    public static MusicManager instance;

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

    }
    public void MenuStartGameMusic()
    {
        audioBG[0].Stop();
        if (!audioBG[0].isPlaying && muteBGMusic == false)
        {
            FadeSoundOn(audioBG[0], 1.5f, 0f, 0.5f);
            audioBG[0].clip = MenuStartGame_1;
            audioBG[0].PlayDelayed(1f);
            audioBG[0].loop = true;
            audioBG[0].Play();
        }
    }
    public void InGameMusic()
    {
        audioBG[0].Stop();
        if (!audioBG[0].isPlaying && muteBGMusic == false)
        {
            FadeSoundOn(audioBG[0], 1.5f, 0f, 0.5f);
            audioBG[0].clip = MenuStartGame_2;
            audioBG[0].PlayDelayed(1f);
            audioBG[0].loop = true;
            audioBG[0].Play();
        }
    }


    //------------------------------------------------------------------------------------------------
    public void StopBGMusic()
    {
        for (int i = 0; i < audioBG.Length; i++)
        {
            audioBG[i].Stop();
        }
    }
    public void PauseBGMusic()
    {
        for (int i = 0; i < audioBG.Length; i++)
        {
            audioBG[i].Pause();
        }
    }

    public void UnPauseBGMusic()
    {
        for (int i = 0; i < audioBG.Length; i++)
        {
            audioBG[i].UnPause();
        }
    }

    public void FadeSoundOn(AudioSource audioSrc, float fadeTime, float minVolume, float maxVolume)
    {
        StartCoroutine(_FadeSoundOn(audioSrc, fadeTime, minVolume, maxVolume));
    }
    IEnumerator _FadeSoundOn(AudioSource audioSrc, float fadeTime, float minVolume, float maxVolume)
    {
        float t = minVolume;
        while (t < fadeTime * maxVolume)
        {
            yield return null;
            t += Time.deltaTime;
            audioSrc.volume = t / fadeTime;
        }
        yield break;
    }

    public void FadeSoundOff(AudioSource audioSrc, float fadeTime, float minVolume, float maxVolume)
    {
        StartCoroutine(_FadeSoundOff(audioSrc, fadeTime, minVolume, maxVolume));
    }
    IEnumerator _FadeSoundOff(AudioSource audioSrc, float fadeTime, float minVolume, float maxVolume)
    {
        float t = fadeTime * maxVolume;
        while (t > minVolume)
        {
            yield return null;
            t -= Time.deltaTime;
            audioSrc.volume = t / fadeTime;
            if (audioSrc.volume < 0.01f)
            {
                audioSrc.Stop();
            }
        }
        yield break;
    }

    public void MuteAllMusic()
    {
        for (int i = 0; i < audioBG.Length; i++)
        {
            audioBG[i].mute = true;
        }
    }

    public void UnMuteAllMusic()
    {
        for (int i = 0; i < audioBG.Length; i++)
        {
            audioBG[i].mute = false;
        }
    }
}

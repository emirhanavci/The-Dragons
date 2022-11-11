using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;
    [SerializeField]
    private AudioClip click, astronot, death,bomb, bgMusic, scream;
    [SerializeField]
    private AudioSource soundFX, bgMusicSource;

	// Use this for initialization
	void Awake ()
    {
        if (instance == null) instance = this;	
	}

    public void PlayClick()
    {
        soundFX.PlayOneShot(click);
    }

    public void PlayAstronot()
    {
        soundFX.PlayOneShot(astronot);
    }

    public void PlayBomb()
    {
        soundFX.PlayOneShot(bomb);
    }

    public void PlayDeath()
    {
        soundFX.PlayOneShot(death);
    }

    public void PlayScream()
    {
        soundFX.PlayOneShot(scream);
    }

    public void PlayMusic()
    {
        bgMusicSource.Play();
    }

}

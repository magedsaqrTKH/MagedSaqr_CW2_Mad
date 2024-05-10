using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip backMusic;
    public AudioClip collectSE;
    public AudioClip eatCandy;
    public AudioClip healSound;

    private void Start()
    {
        musicSource.loop = true;
        musicSource.clip = backMusic;
        musicSource.Play();
    }
    public void SoundEffects(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}

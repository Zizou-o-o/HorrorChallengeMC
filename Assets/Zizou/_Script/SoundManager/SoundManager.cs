using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource loopSource;    
    public AudioSource sfxSource;    

    public AudioClip heartbeat;
    public AudioClip jumpscare;
    public AudioClip stoneScrape;
    public AudioClip grassFootstep;

    void Awake()
    {
        Instance = this;
    }

    public void PlayHeartbeat()
    {
        if (!loopSource.isPlaying)
        {
            loopSource.clip = heartbeat;
            loopSource.loop = true;
            loopSource.Play();
        }
    }

    public void StopHeartbeat()
    {
        loopSource.Stop();
    }

    public void PlayJumpscare()
    {
        sfxSource.PlayOneShot(jumpscare);
    }

    public void PlayScrape()
    {
        sfxSource.PlayOneShot(stoneScrape);
    }

    public void PlayFootstep(AudioSource playerAudio)
    {
        if (!playerAudio.isPlaying)
            playerAudio.PlayOneShot(grassFootstep);
    }
}
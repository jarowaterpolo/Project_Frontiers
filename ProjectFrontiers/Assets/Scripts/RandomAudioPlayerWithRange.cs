using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RandomAudioPlayerWithRange : MonoBehaviour
{
    public AudioSource[] audioSources;
    public float[] MinDelay;
    public float[] MaxDelay;

    public UnityEvent[] StartAudios;
    //private float Timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < StartAudios.Length; i++) 
        {
            StartAudios[i].Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioSwitchTime()
    {
        for (int i = 0; i < StartAudios.Length; i++)
        {
            StartAudios[i].Invoke();
        }
    }

    public void StartAudio(int AudioNumber)
    {
        //Debug.Log("Player audio = " + AudioNumber);
        StartCoroutine(PlayAudio(AudioNumber));
    }

    IEnumerator PlayAudio(int i)
    {
        float minDelay = MinDelay[i];
        float maxDelay = MaxDelay[i];

        //Debug.Log("Play audio in " + minDelay + "to " + maxDelay + "sec");

        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        audioSources[i].Play();

        //Debug.Log("audio played");

        StartCoroutine(PlayAudio(i));
    }
}

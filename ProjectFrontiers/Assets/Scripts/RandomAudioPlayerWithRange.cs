using System.Collections;
using UnityEngine;

public class RandomAudioPlayerWithRange : MonoBehaviour
{
    public AudioSource[] audioSources;
    public float[] MinDelay;
    public float[] MaxDelay;

    //private float Timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAudio(int AudioNumber)
    {
        StartCoroutine(PlayAudio(AudioNumber));
    }

    IEnumerator PlayAudio(int i)
    {
        float minDelay = MinDelay[i];
        float maxDelay = MaxDelay[i];
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        audioSources[i].Play();
    }
}

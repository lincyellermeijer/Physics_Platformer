using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {

    private AudioSource[] allAudioSources;

    void Start()
    {
        allAudioSources = FindObjectsOfType<AudioSource>();
    }

    public void RetryButtonClicked()
    {
        Application.LoadLevel("Menu");

        for (int i = 0; i < allAudioSources.Length; i++)
        {
            allAudioSources[i].Stop();
        }
    }

}

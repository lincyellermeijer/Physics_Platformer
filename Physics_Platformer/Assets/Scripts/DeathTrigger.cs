using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour
{

    private AudioSource[] allAudioSources;

    void Start()
    {
        allAudioSources = FindObjectsOfType<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel("GameOver");

            for (int i = 0; i < allAudioSources.Length; i++)
            {
                allAudioSources[i].Stop();
            }
            
        }
    }
}

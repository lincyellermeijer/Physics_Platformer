using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Finish : MonoBehaviour {

    public Player player;
    private AudioSource[] allAudioSources;
    public Text finishText;

    void Start()
    {
        finishText.text = "";
        allAudioSources = FindObjectsOfType<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
            if (player.count == 5)
            {
                Application.LoadLevel("Win");
                player.count = 0;

                for (int i = 0; i < allAudioSources.Length; i++)
                {
                    allAudioSources[i].Stop();
                }
            }
            else
            {
                finishText.text = "You have " + player.count + "/5 stars";
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            finishText.text = "";
        }
    }

}

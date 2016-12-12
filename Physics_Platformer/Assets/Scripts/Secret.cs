using UnityEngine;
using System.Collections;

public class Secret : MonoBehaviour
{
    public Material PickUp;
    private AudioSource source;
    public GameObject particle;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(particle, transform.position, Quaternion.Euler(-70, -180, -180));
            GameObject.Find("Player").GetComponent<Renderer>().material = PickUp;
            Destroy(gameObject);
        }
    }
}
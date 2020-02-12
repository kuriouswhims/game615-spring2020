using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject bang;
    public AudioClip vampire;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(bang, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        audioSource.PlayOneShot(vampire, 1F);
        Invoke("ByeBye",3);
    }

    void ByeBye()
    {
        bang.SetActive(false);
    }
}

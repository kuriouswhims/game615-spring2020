using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndExplosion : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip vampire;

    void Start()
    {
        audioSource.PlayOneShot(vampire, 1F);
    }

}

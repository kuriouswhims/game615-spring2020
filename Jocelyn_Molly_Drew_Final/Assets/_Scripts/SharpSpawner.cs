using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpSpawner : MonoBehaviour
{
    public float sharpSpawnFrequency = 0.5f;
    public GameObject sharp;

    private void OnEnable()
    {
        StartCoroutine(SharpSpawn());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator SharpSpawn()
    {
        WaitForSeconds sharpDelay = new WaitForSeconds(sharpSpawnFrequency);
        while (true)
        {
            yield return sharpDelay;
            Instantiate(sharp, transform.position, Quaternion.identity);
        }
    }
}

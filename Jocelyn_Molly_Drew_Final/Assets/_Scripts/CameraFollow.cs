using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);
        //currently using transform.position.y as our Y-axis follow, but might want to switch to player's y if we have vertical movement in our levels
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
    }

    public void ResetCameraPosition()
    {
        transform.position = originalPosition;
    }
}

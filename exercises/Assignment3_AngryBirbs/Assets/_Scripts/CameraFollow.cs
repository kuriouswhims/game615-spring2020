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
        if (player.parent == null)
        {
            Vector3 newPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime); //camera position z is because we're in camera 
        }
         
    }

    public void resetCameraPosition()
    {
        transform.position = originalPosition; 
    }
}

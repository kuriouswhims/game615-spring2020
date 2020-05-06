using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorActivate : MonoBehaviour
{
    public ElevatorMove elevatorMove; 

    // Start is called before the first frame update
    void Start()
    {
        //elevatorMove = GetComponent<ElevatorMove>();
        elevatorMove.enabled = false; 
        Debug.Log("fuck me gently with a spoon");
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Yeet"))
        {
            elevatorMove.enabled = true;
            Debug.Log("i hate life");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Yeet"))
        {
            elevatorMove.enabled = false;
            Debug.Log("good lord");
        }
    }
}

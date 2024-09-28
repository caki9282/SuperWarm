using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class timeScript : MonoBehaviour
    {
    public GameObject rightHandReference;


    Vector3 previousRightHandPosition = new Vector3(0,0,0);

    void Update() {
        // 
        // Get the distance between frames on the hand
        float distance = Vector3.Distance(previousRightHandPosition, rightHandReference.transform.position);
        // Now YOU need to figure out to set the time scale to a lower value
        // when the player moves their hands more
        Time.timeScale = 0.5f; // <- This will make the game move at half speed
        
        // dont forget to set the previous position
        previousRightHandPosition = rightHandReference.transform.position;
    }
}

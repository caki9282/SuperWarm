using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        // Check if the object collides with a specific object (e.g., Player)
        if (other.CompareTag("bullet")) {
            Destroy(gameObject);
        }
    }
}

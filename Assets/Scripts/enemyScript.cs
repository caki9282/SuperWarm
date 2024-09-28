using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    [SerializeField] private float move_speed = 10f;

    private GameObject playerTarget;

    private void OnTriggerEnter(Collider other) {
        playerTarget = other.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        // Only move forward if there is a player target
        if (playerTarget != null) {
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * move_speed;
        }
    }

    
}

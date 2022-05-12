using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform endPos;

    public float negateRotation = 1f;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            
            Vector3 portalToPlayer = player.position - transform.position;
                        
            if (portalToPlayer.z * negateRotation < 0f) {
                player.position = endPos.position + portalToPlayer;
            }
        }
    }
}
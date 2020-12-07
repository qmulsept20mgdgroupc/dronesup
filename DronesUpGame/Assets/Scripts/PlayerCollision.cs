using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The game end if the drone collides with any obstacle
public class PlayerCollision : MonoBehaviour
{
    public DroneController controller;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            controller.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            

        }
    }
}

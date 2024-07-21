using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {
    public PlayerMovement movement;
    public AudioSource Death;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //script referrence

        //fire some script only when the player hits an obstacle
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //stop player movement
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            // play oof
            Death.Play();

        }
    }


}

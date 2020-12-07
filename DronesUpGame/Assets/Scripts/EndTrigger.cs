using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this will trigger the game manager to either end the game or go to the next level depending on if the player collected all of the battery cells
public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Appear;
    
    private void OnTriggerEnter()
    {
        Appear = GameObject.FindGameObjectWithTag("PickUpObject");
        
        if (Appear.GetComponent<MeshRenderer>().enabled && (Collectible.countCollect == Collectible.totalCollectibles))
        {
            gameManager.CompleteLevel();
        }
        else
        {
            gameManager.EndGame();
        }
        
    }
}
